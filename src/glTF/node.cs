namespace glTFLib
{
    /// <summary>
    /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/README.md#node
    /// </summary>
    public class Node
    {
        public string Name { get; set; }

        public uint[] Children { get; set; }

        public float[] Matrix { get; set; }
        public float[] Rotation { get; set; }
        public float[] Scale { get; set; }
        public float[] Translation { get; set; }

        public uint Camera { get; set; }

        public uint Mesh { get; set; }
        public float[] Weights { get; set; }
        public uint Skin { get; set; }

    }
}