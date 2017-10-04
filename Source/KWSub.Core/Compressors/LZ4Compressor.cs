using LZ4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWSub.Core.Compressors
{
    public class LZ4Compressor : ICompressor
    {
        public void WriteData(Stream outputStream, byte[] data)
        {
            using (var lz4Stream = new LZ4Stream(outputStream, LZ4StreamMode.Compress))
                lz4Stream.Write(data, 0, data.Length);
        }

        public byte[] ReadData(Stream inputStream)
        {
            // MattMatt2000: Ha, I had to go to sleep... sry ;-;;
            return new byte[] { };
        }
    }
}
