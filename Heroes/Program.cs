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
            string[] mapStrings =
            {
                "▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲",
                "▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲&&&&&&&&&&&&&~~~~~~",
                "▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&~~~~~~~~~",
                "▲▲▲▲▲▲&&&&▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲&&&&&&&&&&&&&&&&&&&&~~~~~~~~~~~~~~~~",
                "&&&&&&&&&&&&&&&&▲▲▲▲▲▲▲&&&&&&&&&&&&&&&&&&&&&&&&~~~~~~~~~~~~~~~",
                "&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&~~~~~~~~~~~~~~~~~~~~~~",
                "&&&&&&&&&&&&&&&&&&&&&&&&&&&~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "&&&&&&&&&###&&&&&&&&&&&&&&&&&^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "&&&&&&^^####^^^^^^^^&&^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^&&^^^^##^^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^#^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^#^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^#^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^^#^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^#^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"
            };


            Maps.AddMaps(new KeyValuePair<string, Map>("Test Map", new Map(mapStrings)));

            Player player = new Player();
            player.MoveToMap("Test Map", 4, 15);
            
            while (true)
            {
                player.StartControl();
                Console.SetCursorPosition(0, 0);
                MapDisplayController.Display(Maps.MapDictionary["Test Map"]);
                Thread.Sleep(70);
            }

        }


    }
}
