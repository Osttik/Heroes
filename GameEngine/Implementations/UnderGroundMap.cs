using GameEngine.Abstracts;
using GameEngine.Implementations.Controllers;
using GameEngine.Implementations.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Implementations
{
    class UnderGroundMap
    {
        public int Heigth { get => _map.GetLength(0); }
        public int Lenght { get => _map.GetLength(1); }
        public string Name { get; set; }
        public MapController MapController { get; set; }

        private MapObject[,] _map;

        public UnderGroundMap() : this(64, 64)
        {
        }

        public UnderGroundMap(string[] stringsMap) : this(stringsMap.Length, stringsMap[0].Length)
        {
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Lenght; j++)
                {
                    _map[i, j] = GetObjectBySybol(stringsMap[i][j]);
                }
            }
        }

        public UnderGroundMap(int h, int l)
        {
            MapController = new MapController();
            _map = new MapObject[h, l];
        }

        public MapObject this[int i, int j]
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
                    return UnknownSymbol.Instatiate;
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
