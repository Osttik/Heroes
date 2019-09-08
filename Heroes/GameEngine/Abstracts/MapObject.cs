using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Abstracts
{
    // ҉ ҈ ֎ ֍ ۩ ∷
    public abstract class MapObject
    {
        public char Symbol { get; set; }
        public float SpeedBuff { get; set; }

        public abstract MapObject GetInstatiate();
    }
}
