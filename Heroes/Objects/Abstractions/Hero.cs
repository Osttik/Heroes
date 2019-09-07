using Heroes.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Objects.Abstractions
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public IBackPack BackPack { get; set; }

    }
}
