using Heroes.GameEngine.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations
{
    public class Ground : MapObject
    {
        static Ground()
        {
            Symbol = '#';
        }
        
    }
}
