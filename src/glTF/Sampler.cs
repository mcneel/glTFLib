namespace glTFLib
{
    /// <summary>
    /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/README.md#reference-material
    /// </summary>
    public class Sampler
    {
        public string Name { get; set; }

        public uint MagFilter { get; set; }
        public uint MinFilter { get; set; }
        public uint WrapS { get; set; }
        public uint WrapT { get; set; }
    }
}