using Heroes.GameEngine.Abstracts;
using Heroes.GameEngine.Implementations.Controllers;
using Heroes.GameEngine.Implementations.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations
{
    public class Map
    {
        public int Heigth { get => _map.GetLength(0); }
        public int Lenght { get => _map.GetLength(1); }
        public string Name { get; set; }
        public MapController MapController { get; set; }

        private MapObject[,] _map;

        public Map(): this(64, 64)
        {
        }

        public Map(string[] stringsMap): this(stringsMap.Length, stringsMap[0].Length)
        {
            for(int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Lenght; j++)
                {
                    _map[i, j] = GetObjectBySybol(stringsMap[i][j]);
                }
            }
        }

        public Map(int h, int l)
        {
            MapController = new MapController();
            _map = new MapObject[h, l];
        }

        public MapObject this [int i, int j]
        {
            get => _map[i, j];
            set => _map[i, j] = value;
        }

        public MapObject GetObjectBySybol(char symbol)
        {
            switch (symbol)
            {
                case '~':
                    return Water.Instatiate;
                case '▲':
                    return Mountain.Instatiate;
                case '#':
                    return Road.Instatiate;
                case '^':
                    return Ground.Instatiate;
                case '&':
                    return Forest.Instatiate;

                case '☎':
                default:
                    return BadSymbol.Instatiate;
            }
        }

        public override string ToString()
        {
            string mapString = "";
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Lenght; j++)
                {
                    mapString += _map[i, j].Symbol;
                }
                mapString += '\n';
            }

            return mapString;
        }
    }
}
