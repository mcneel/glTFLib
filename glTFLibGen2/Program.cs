using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFLibGen2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] paths = Directory.GetFiles(@"C:\dev\mcneel\glTF\specification\2.0\schema");
            string path = @"C:\dev\mcneel\glTF\specification\2.0\schema\glTF.schema.json";
            string destinationDir = @"C:\dev\mcneel\glTFLib\src\gen2";

            var schemaTask = Task.Run(() => JsonSchema4.FromFileAsync(path));
            var schema = schemaTask.GetAwaiter().GetResult();

            var settings = new CSharpGeneratorSettings
            {
                
                HandleReferences = true,
                Namespace = "glTFLib.Gen",
                ClassStyle = CSharpClassStyle.Poco,
                ArrayType = "System.Collections.Generic.List",
                ArrayBaseType = "System.Collections.Generic.List"

            };

            //var generator = new CSharpGenerator(schema, settings);
            var generator = new CSharpGenerator(schema, settings);
            var file = generator.GenerateFile();

            string destinationPath = Path.ChangeExtension(path, ".cs");

            string fileName = Path.GetFileName(destinationPath);
            string finalPath = Path.Combine(destinationDir, fileName);

            File.WriteAllText(finalPath, file);
        }
    }
}
