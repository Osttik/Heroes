using GameEnviroment.Helpers.Interfaces;
using GameEnviroment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnviroment.Interfaces
{
    public interface IItem
    {
        IDescription Description { get; set; }
        List<IEffect> Effects { get; set; }
        Types ItemType { get; set; }
        bool IsClickable { get; set; }
        
        
    }
}
