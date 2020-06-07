using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article1_5
{
    class CPU
    {
        public CPU()
        {

        }
        public CPU(int coreNum, int frequency)
        {
            CoreNum = coreNum;
            Frequency = frequency;
        }
        public int CoreNum;
        public int Frequency;
    }
}
