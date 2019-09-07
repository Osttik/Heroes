using Heroes.Helpers.Implementations;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heroes.GameEngine.Implementations.MapObjects;
using Heroes.GameEngine.Implementations;

namespace Heroes
{
    class Program
    {

        static void Main(string[] args)
        {
            if (!File.Exists(StandartDefines.DefinesPath))
            {
                StandartDefines.Save();
            }

           // Map map = new Map(File.ReadAllLines(@"C:\Users\Natalya\Desktop\Map.txt"));

            //Console.WriteLine(map.ToString());
        }
    }
}
