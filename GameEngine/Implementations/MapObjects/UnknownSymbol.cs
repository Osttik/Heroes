using GameEngine.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Implementations.MapObjects
{
    public class UnknownSymbol: MapObject
    {
        public static UnknownSymbol Instatiate;

        public UnknownSymbol()
        {
            Symbol = '☎';
            SpeedBuff = 0;
        }

        static UnknownSymbol() { 
            Instatiate = new UnknownSymbol();
        }

        public override MapObject GetInstatiate()
        {
            return Instatiate;
        }
    }
}
