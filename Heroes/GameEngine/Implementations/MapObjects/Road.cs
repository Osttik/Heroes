using Heroes.GameEngine.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations.MapObjects
{
    public class Road : MapObject
    {
        public static Road Instatiate;

        public Road()
        {
            SpeedBuff = 1.3f;
            Symbol = '#';
        }

        static Road()
        {
            Instatiate = new Road();
        }

        public override MapObject GetInstatiate()
        {
            return Instatiate;
        }
    }
}
