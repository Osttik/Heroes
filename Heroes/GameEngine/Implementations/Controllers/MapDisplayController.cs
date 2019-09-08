using Heroes.Helpers.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations.Controllers
{
    public static class MapDisplayController
    {
        public static void Display(Map map)
        {
            string mapString = "";
            for (int i = 0; i < map.Heigth; i++)
            {
                for (int j = 0; j < map.Lenght; j++)
                {
                    PlayerObject player = map.MapController.GetPlayerByPosition(i, j);
                    if (player.CurrentMap != StandartDefines.MapZero)
                    {
                        mapString += player.Symbol;
                    }
                    else
                    {
                        mapString += map[i, j].Symbol;
                    }
                }
                mapString += '\n';
            }

            Console.WriteLine(mapString);
        }
    }
}
