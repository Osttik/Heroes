﻿using Heroes.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Objects.Implementations
{
    public class Player : IUnit
    {

        public IBackPack BackPack { get; set; }
    }
}
