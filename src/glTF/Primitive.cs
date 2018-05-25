using System.Collections.Generic;

namespace glTFLib
{
    /// <summary>
    /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/README.md#meshes
    /// </summary>
    public class Primitive
    {
        public string Name { get; set; }
        public uint Indices { get; set; }
        public uint Material { get; set; }
        public uint Mode { get; set; }
        public Dictionary<string, int> Attributes { get; set; }
        public Target[] Targets { get; set; }

    }
}
