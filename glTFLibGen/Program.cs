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
            //Setup 

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

            //Copy schema files to tmpDir

            var paths = Directory.GetFiles(@".\..\..\..\glTF\specification\2.0\schema");
            var pathsEx = Directory.GetFiles(@".\..\..\..\glTF\extensions", "*.schema.json", SearchOption.AllDirectories);

            var arrValuesPath = @".\..\..\..\glTF\specification\1.0\schema\arrayValues.schema.json";

            CopyFile(arrValuesPath, tmpDir);

            foreach (var path in paths)
                CopyFile(path, tmpDir);

            var command = "";

            var extensionPaths = new List<string>();

            foreach (var path in pathsEx)
                extensionPaths.Add(CopyFile(path, tmpDir));

            //CodeGen

            command = "cd " + tmpDir;

            run.StandardInput.WriteLine(command);

            command = "quicktype -s schema glTF.schema.json -l csharp -o glTF-api.cs --namespace glTFLib --csharp-version 6 --array-type list --number-type double --features complete --any-type object --no-combine-classes --top-level GlTF";

            run.StandardInput.WriteLine(command);

            foreach (var path in extensionPaths)
            {
                var fileName = Path.GetFileName(path);
                var parts = fileName.Split('.');
                var topLevel = "";
                for (int i = 0; i < parts.Length - 2; i++)
                    topLevel += parts[i].First().ToString().ToUpper() + parts[i].Substring(1);

                var fileNameCS = "ext." + topLevel + ".cs";

                command = "quicktype -s schema "+ fileName +" -l csharp -o "+ fileNameCS + " --namespace glTFLib.Extensions --csharp-version 6 --array-type list --number-type double --features complete --any-type object --no-combine-classes --top-level " + topLevel;

                run.StandardInput.WriteLine(command);
            }

            //Copy generated files to gen directory.

            var pathsGen = Directory.GetFiles(tmpDir, "*.cs");

            foreach (var path in pathsGen)
                CopyFile(path, genDir);

            //run.WaitForExit();

        }

        public static string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }

        public static string CopyFile(string path, string destDir)
        {
            var fileName = Path.GetFileName(path);
            var destinationFileName = Path.Combine(destDir, fileName);
            File.Copy(path, destinationFileName, true);
            return destinationFileName;
        }


    }
}
