using Newtonsoft.Json.Schema;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSchemaGen
{
    class Program
    {
        static void Main(string[] args)
        {

            //string path = @"C:\dev\mcneel\glTF\specification\2.0\schema\node.schema.json";

            string[] paths = Directory.GetFiles(@"C:\dev\mcneel\glTF\specification\2.0\schema");
            string destinationDir = @"C:\dev\mcneel\glTFLib\srcgen";

            foreach (var path in paths)
            {
                var schemaTask = Task.Run(() => JsonSchema4.FromFileAsync(path));
                var schema = schemaTask.GetAwaiter().GetResult();

                var settings = new CSharpGeneratorSettings
                {
                    
                    HandleReferences = false,
                    Namespace = "glTFLib.Gen",
                    ClassStyle = CSharpClassStyle.Poco

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
}
