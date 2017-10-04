using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KWSub.Core
{
    public interface ICompressor
    {
        void    WriteData(Stream outputStream, byte[] data);
        byte[]  ReadData(Stream inputStream);
    }

}
