using Heroes.GameEngine.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations.MapObjects
{
    public class Water : MapObject
    {
        public static Water Instatiate;

        public Water()
        {
            Symbol = '&';
            SpeedBuff = 1.5f;
        }

        static Water()
        {
            Instatiate = new Water();
        }

        public override MapObject GetInstatiate()
        {
            return Instatiate;
        }

    }
}
