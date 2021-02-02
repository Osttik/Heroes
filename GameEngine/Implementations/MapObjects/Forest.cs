using GameEngine.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Implementations.MapObjects
{
    public class Forest : MapObject
    {
        public static Forest Instatiate;

        public Forest()
        {
            Symbol = '&';
            SpeedBuff = 0.5f;
        }

        static Forest()
        {
            Instatiate = new Forest();
        }

        public override MapObject GetInstatiate()
        {
            return Instatiate;
        }
    }
}
