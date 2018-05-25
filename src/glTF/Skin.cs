namespace glTFLib
{
    public class Skin
    {
        public string Name { get; set; }
        public uint InverseBindMatrices { get; set; }
        public uint[] Joints { get; set; }
        public uint Skeleton { get; set; }
    }
}
