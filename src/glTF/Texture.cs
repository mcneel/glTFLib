namespace glTFLib
{
    /// <summary>
    /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/README.md#texture
    /// </summary>
    public class Texture
    {
        public string Name { get; set; }
        public uint Sampler { get; set; }
        public uint Source { get; set; }
    }
}