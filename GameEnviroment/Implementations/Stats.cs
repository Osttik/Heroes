using Configurations;
using GameEnviroment.Helpers.Implementations;
using GameEnviroment.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnviroment.Implementations
{
    public class Stats
    {
        public Attributes Attributes { get; private set; }

        public float Mana { get; set; }
        public float Health { get; set; }
        public float Endurance { get; set; }

        public Stats()
        {
            Attributes = new Attributes();
        }

        public void RescaleStats()
        {
            Mana = StandartDefines.MinMana + 50 * Attributes.Inteligence;
            Health = StandartDefines.MinHealth + 20 * Attributes.Strenght;
            Endurance = StandartDefines.MinEndurance + 10 * Attributes.Agility;
        }
    }
}
