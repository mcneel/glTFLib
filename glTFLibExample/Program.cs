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
                Scenes = new List<Scene>()
            };

            var node = new Node
            {
                Name = "firstNode"
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
