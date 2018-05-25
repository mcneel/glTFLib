using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFLib
{
    public class Accessor
    {
        public uint BufferView { get; set; }
        public uint BufferOffset { get; set; }
        public uint ComponentType { get; set; }
        public uint Count { get; set; }
        public object[] Max { get; set; }
        public object[] Min { get; set; }
        public string Type { get; set; }
    }
}
