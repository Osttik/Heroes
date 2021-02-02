using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Implementations
{
    public static class Maps
    {
        public static Dictionary<string, Map> MapDictionary;

        static Maps()
        {
            MapDictionary = new Dictionary<string, Map>();
        }

        public static void AddMaps(params KeyValuePair<string, Map>[] maps)
        {
            foreach (var map in maps)
            {
                MapDictionary.Add(map.Key, map.Value);
            }
        }
        public static void RemoveMaps(params KeyValuePair<string, Map>[] maps)
        {
            foreach (var map in maps)
            {
                MapDictionary.Remove(map.Key);
            }
        }
    }
}
