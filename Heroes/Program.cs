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
using Heroes.Helpers.Implementations.Descriptions;

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

            Console.CursorVisible = false;

            Maps.AddMaps(new KeyValuePair<string, Map>("Test Map", new Map(mapStrings)));

            Player player = new Player();
            player.MoveToMap("Test Map", 4, 15);

            MapDescription m = new MapDescription()
            {
                MapName = "Test wordl"
            };
            m.Add("228335");

            while (true)
            {
                player.StartControl();
                Console.SetCursorPosition(0, 0);
                Displayer.Display(Maps.MapDictionary["Test Map"], m);
                Thread.Sleep(70);
            }

        }


    }
}
