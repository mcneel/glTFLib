using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace glTFLibGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmpDir = GetTemporaryDirectory();

            var psi = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                UseShellExecute = false,

                //depth of relative path relate to this repository's glTF submodule

                WorkingDirectory = @".\..\..\..\glTF\specification\2.0\schema"
            };

            var fullDir = new DirectoryInfo(Path.GetFullPath(psi.WorkingDirectory));
            fullDir = fullDir.Parent.Parent.Parent.Parent;
            var genDir = Path.Combine(fullDir.FullName, @"src\gen" );

            var run = Process.Start(psi);

            var paths = Directory.GetFiles(@".\..\..\..\glTF\specification\2.0\schema");

            var schemaPaths = new List<string>();

            foreach (var path in paths)
            {
                var fileName = Path.GetFileName(path);
                var destinationFileName = Path.Combine(tmpDir, fileName);
                File.Copy(path, destinationFileName);
                schemaPaths.Add(destinationFileName);

                Console.WriteLine(path);
            }

            var pathsEx = Directory.GetFiles(@".\..\..\..\glTF\extensions", "*.schema.json", SearchOption.AllDirectories);

            var command = "";

            var extensionPaths = new List<string>();
            foreach (var path in pathsEx)
            {
                var fileName = Path.GetFileName(path);
                var destinationFileName = Path.Combine(tmpDir, fileName);
                File.Copy(path, destinationFileName);
                extensionPaths.Add(destinationFileName);

            }

            command = "cd " + tmpDir;

            run.StandardInput.WriteLine(command);

            command = "quicktype -s schema glTF.schema.json -l csharp -o GlTF_auto.cs --namespace glTFLib --csharp-version 6 --array-type list --number-type double --features complete --any-type object --no-combine-classes --top-level GlTF";

            run.StandardInput.WriteLine(command);

            foreach (var path in extensionPaths)
            {
                var fileName = Path.GetFileName(path);
                var fileNameCS = Path.ChangeExtension(fileName, ".cs");
                var parts = fileName.Split('.');
                var topLevel = "";
                for (int i = 0; i < parts.Length - 2; i++)
                    topLevel += parts[i].First().ToString().ToUpper() + parts[i].Substring(1);

                command = "quicktype -s schema "+ fileName +" -l csharp -o "+ fileNameCS + " --namespace glTFLib --csharp-version 6 --array-type list --number-type double --features complete --any-type object --no-combine-classes --top-level " + topLevel;
                run.StandardInput.WriteLine(command);
            }

            var exe = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var pathsGen = Directory.GetFiles(tmpDir, "*.cs");

            foreach (var path in pathsGen)
            {
                var fileName = Path.GetFileName(path);
                var destinationFileName = Path.Combine(genDir, fileName);
                File.Copy(path, destinationFileName, true);
            }


            command = "cd " + genDir;

            run.StandardInput.WriteLine(command);

            run.WaitForExit();

            //Console.ReadKey();
        }

        public static string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }


    }
}
