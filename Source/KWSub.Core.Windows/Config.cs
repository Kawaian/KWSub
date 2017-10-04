using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWSub.Core
{
    public class Config
    {
        public ICompressor GetOptimalCompressor()
        {
            // LZ4 is the default compressor on windows
            return new Compressors.LZ4Compressor();
        }


    }
}
