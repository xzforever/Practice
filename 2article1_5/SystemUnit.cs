using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article1_5
{
    class SystemUnit
    {
        public SystemUnit()
        {
            CPU = new CPU();
            Motherboard = new Motherboard();
            RAM = new RAM();
            PowerSupply = new PowerSupply();
            GraphicCard = new GraphicCard();
            HDD = new HDD();
        }
        public CPU CPU;
        public Motherboard Motherboard;
        public RAM RAM;
        public PowerSupply PowerSupply;
        public GraphicCard GraphicCard;
        public HDD HDD;
    }
}
