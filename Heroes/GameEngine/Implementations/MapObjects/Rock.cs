using Heroes.GameEngine.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations.MapObjects
{
    public class Rock : MapObject
    {
        public static Rock Instatiate;

        public Rock()
        {
            Symbol = '/';
            SpeedBuff = 0.3f;
        }

        static Rock()
        {
            Instatiate = new Rock();
        }

        public override MapObject GetInstatiate()
        {
            return Instatiate;
        }

    }
}
