using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFLib
{
    public class BufferView
    {
        public uint Buffer { get; set; }
        public uint ByteLength { get; set; }
        public uint ByteOffset { get; set; }
        public uint ByteStride { get; set; }
        public uint Target { get; set; }
    }
}
