using Heroes.Helpers.Implementations;
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroes.GameEngine.Implementations.MapObjects;
using Heroes.GameEngine.Implementations;
using Heroes.GameEngine.Implementations.Controllers;
using Heroes.Objects.Implementations;
using System.Threading;

namespace Heroes
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            if (!File.Exists(StandartDefines.DefinesPath))
            {
                StandartDefines.Save();
            }

            Start();

            Console.Read();
        }

        public static void Start()
        {

            Maps.AddMaps(new KeyValuePair<string, Map>("Test Map", new Map(File.ReadAllLines(@"C:\Users\Natalya\Desktop\Map.txt"))));

            Player player = new Player();
            player.MoveToMap("Test Map", 4, 15);

            Task.Run(() =>
            {
                while (true)
                {
                    player.StartControl();
                    Console.Clear();
                    MapDisplayController.Display(Maps.MapDictionary["Test Map"]);
                    Thread.Sleep(70);
                }
            });

        }


    }
}
