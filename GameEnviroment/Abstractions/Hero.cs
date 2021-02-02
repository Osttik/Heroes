using GameEnviroment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnviroment.Abstractions
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public IBackPack BackPack { get; set; }

    }
}
