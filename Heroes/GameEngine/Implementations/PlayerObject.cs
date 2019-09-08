using Heroes.GameEngine.Abstracts;
using Heroes.Helpers.Implementations;
using Heroes.GameEngine.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations
{
    public class PlayerObject
    {
        public readonly char Symbol;
        public readonly Position Position;
        public string CurrentMap { get; set; }

        public PlayerObject()
        {
            Symbol = 'P';
            Position = new Position();
            CurrentMap = "Zero";
        }

        public PlayerObject(int x, int y) : this()
        {
            Position.XPosition = x;
            Position.YPosition = y;
        }

        public PlayerObject(char symbol, int x, int y) : this(x, y)
        {
            Symbol = symbol;
        }

        public void MoveToMap(string mapName, int x, int y)
        {
            if (Maps.MapDictionary.Keys.Contains(CurrentMap))
            {
                Map prevMap = Maps.MapDictionary[CurrentMap];
                prevMap.MapController.RemovePlayer(this);
            }

            Map newMap = Maps.MapDictionary[mapName];

            Position.SetMaxCoordinations(newMap.Heigth, newMap.Lenght);

            Position.XPosition = x;
            Position.YPosition = y;

            CurrentMap = mapName;

            newMap.MapController.AddPlayer(this);
        }

    }
}
