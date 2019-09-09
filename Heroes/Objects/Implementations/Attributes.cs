using Heroes.Helpers.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Objects.Implementations
{
    public class Attributes
    {
        public float Agility { get; set; }
        public float Inteligence { get; set; }
        public float Strenght { get; set; }

        public Attributes()
        {
            Agility = StandartDefines.MinAgility;
            Inteligence = StandartDefines.MinInteligence;
            Strenght = StandartDefines.MinStrenght;
        }
    }
}
