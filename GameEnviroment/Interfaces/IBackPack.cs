using System.Collections.Generic;

namespace GameEnviroment.Interfaces
{
    public interface IBackPack
    {
        List<IItem> Items { get; set; }
    }
}
