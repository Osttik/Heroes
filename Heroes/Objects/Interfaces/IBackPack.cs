﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Objects.Interfaces
{
    public interface IBackPack
    {
        List<IItem> Items { get; set; }
    }
}
