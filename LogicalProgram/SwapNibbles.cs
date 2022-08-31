using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class SwapNibbles
    {
        public static int SwappingNibbles(int x)
        {

            return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
           
        }
    }
}
