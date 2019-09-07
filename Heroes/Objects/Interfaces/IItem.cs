using Heroes.Helpers.Interfaces;
using Heroes.Objects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Objects.Interfaces
{
    public interface IItem
    {
        IDescription Description { get; set; }
        List<IEffect> Effects { get; set; }
        Types ItemType { get; set; }
        bool IsClickable { get; set; }
        
        
    }
}
