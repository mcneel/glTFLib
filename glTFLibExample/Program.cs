using glTFLib;
using System;
using System.Collections.Generic;

namespace glTFLibExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var gltf = new GlTF
            {
                Nodes = new List<Node>(),
                Scenes = new List<Scene>(),
                Asset = new AssetClass
                {
                    Generator = "glTFLib",
                    Copyright = "2018",
                    Version = "2.0"
                },
                Scene = 0,
                Cameras = new List<Camera>()
            };

            var camera = new Camera
            {
                Type = "perspective",
                Perspective = new CameraPerspective
                {
                    Znear = 1.0,
                    Yfov = 35.0
                }
            };

            gltf.Cameras.Add(camera);

            var node = new Node
            {
                Name = "firstNode",
                Camera = 0
            };

            gltf.Nodes.Add(node);

            var scene = new Scene
            {
                Name = "firstScene",
                Nodes = new List<long>
                {
                    0
                }
            };

            gltf.Scenes.Add(scene);

            Console.WriteLine(gltf.ToJson());

            Console.ReadLine();
        }
    }
}
