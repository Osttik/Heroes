using Heroes.GameEngine.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations.MapObjects
{
    public class UnderGroundEntrance: MapObject
    {
        public static UnderGroundEntrance Instatiate;

        public UnderGroundEntrance()
        {
            Symbol = 'O';
            SpeedBuff = 0.5f;
        }

        static UnderGroundEntrance()
        {
            Instatiate = new UnderGroundEntrance();
        }

        public override MapObject GetInstatiate()
        {
            return Instatiate;
        }
    }

}
