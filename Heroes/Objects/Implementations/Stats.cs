using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Objects.Implementations
{
    public class Stats
    {
        public Attributes Attributes { get; private set; }

        public float Mana { get; set; }
        public float Health { get; set; }
        public float Endurance { get; set; }

        public void RescaleStats()
        {

        }
    }
}
