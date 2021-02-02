using GameEngine.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Implementations.MapObjects
{
    public class Mountain : MapObject
    {
        public static Mountain Instatiate;

        public Mountain()
        {
            Symbol = '▲';
            SpeedBuff = 0.3f;
        }

        static Mountain()
        {
            Instatiate = new Mountain();
        }

        public override MapObject GetInstatiate()
        {
            return Instatiate;
        }

    }
}
