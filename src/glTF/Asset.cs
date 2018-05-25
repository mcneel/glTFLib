namespace glTFLib
{
    public class Asset
    {
        public string Version { get; set; }
        public string MinVersion { get; set; }
        public string Generator { get; set; }
        public string Copyright { get; set; }

        public Texture[] Textures { get; set; }

        public Image[] Images { get; set; }

        public Sampler[] Samplers { get; set; }

    }
}
