using Heroes.GameEngine.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations.MapObjects
{
    public class BadSymbol: MapObject
    {
        public static BadSymbol Instatiate;

        public BadSymbol()
        {
            Symbol = '☎';
            SpeedBuff = 0;
        }

        static BadSymbol() { 
            Instatiate = new BadSymbol();
        }

        public override MapObject GetInstatiate()
        {
            return Instatiate;
        }
    }
}
