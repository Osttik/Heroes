using Heroes.GameEngine.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations.MapObjects
{
    public class Ground : MapObject
    {
        public static Ground Instatiate;

        public Ground()
        {
            Symbol = '^';
            SpeedBuff = 1f;
        }

        static Ground()
        {
            Instatiate = new Ground();
        }

        public override MapObject GetInstatiate()
        {
            return Instatiate;
        }

    }
}
