using gltf = glTFLoader;
using glTFLoader.Schema;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace glTFLibExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Gltf 
            {
                Scene = 0,
                Asset = new Asset 
                {
                    Generator = "glTFLib",
                    Copyright = "2021",
                    Version = "2.0"
                }
            };

            var cameras = new List<Camera>();

            var camera = new Camera
            {
                Type = Camera.TypeEnum.perspective,
                Perspective = new CameraPerspective
                {
                    Znear = 1f,
                    Yfov = 1f,
                    AspectRatio = 10
                }
            };

            cameras.Add(camera);

            var nodes = new List<Node>();

            var node = new Node 
            {
                Name = "first node",
                Camera = 0
            };

            nodes.Add(node);

            var scenes = new List<Scene>();

            var scene = new Scene 
            {
                Name = "firstScene",
                Nodes = new int[] { 0 }
            };

            scenes.Add(scene);

            model.Cameras = cameras.ToArray();
            model.Nodes = nodes.ToArray();
            model.Scenes = scenes.ToArray();

            Console.WriteLine( gltf.Interface.SerializeModel(model) );

            string tempOutputFile = Path.GetTempFileName();
            string glbOutputFile = Path.ChangeExtension(tempOutputFile, "glb");
            string gltfOutputFile = Path.ChangeExtension(tempOutputFile, "gltf");

            Console.WriteLine("Saving gltf to: " + gltfOutputFile);
            gltf.Interface.SaveModel(model, gltfOutputFile);

            Console.WriteLine("Saving glb to: " + glbOutputFile);
            gltf.Interface.SaveBinaryModel(model, null, glbOutputFile);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
