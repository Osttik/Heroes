﻿using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using GameEngine.Implementations;
using System.Threading;
using GameEnviroment.Helpers.Implementations;
using GameEnviroment.Implementations;
using GameEnviroment.Helpers.Implementations.Descriptions;
using Configurations;
using UI;

namespace Main
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
            (new UIWindow()).Start();
            string[] mapStrings =
            {
                "▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲~~~~~~~~~~~~~~~~~&&&&&&&&&&&&~~~~~~",
                "▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲&&&&&&&&&&&&&~~~~~~~~~~~~~~~~~~~~~~~~~~~~~&&&&&&&~~~~~",
                "▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~&&&&~&&&&~~~~",
                "▲▲▲▲▲▲&&&&▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲&&&&&&&&&&&&&&&&&&&&~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~&&&&&~~~~",
                "&&&&&&&&&&&&&&&&▲▲▲▲▲▲▲&&&&&&&&&&&&&&&&&&&&&&&&~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~▲▲▲▲~~~~~~~~",
                "&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~▲▲~~~~~~~~",
                "&&&&&&&&&&&&&&&&&&&&&&&&&&&~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~▲~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "&&&&&&&&&###&&&&&&&&&&&&&&&&&^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "&&&&&&^^####^^^^^^^^&&^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~▲~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^&&^^^^##^^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^#^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~▲~~~~~~~~~~~~~~~~~~~~~~~~&&~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^#^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~&&~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^#^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^^#^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^#^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^^^##^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^^^^##^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^^^^##^^^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^^^^##^^^^^^^#^^^#^^^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^^^^##################^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^^^##^^^^^^^^##^^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^^##^^^^^^^^^#^^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^^##^^^^^^^^^#^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                "^^^^^^^^^^^##^^^^^^^^^^^#^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"
            };

            Console.CursorVisible = false;

            Maps.AddMaps(new KeyValuePair<string, Map>("Test Map", new Map(mapStrings)));

            Player player = new Player();
            player.MoveToMap("Test Map", 4, 15);

            MapDescription m = new MapDescription()
            {
                MapName = "Test wordl"
            };

            m.Add("Whens", "in", "world", "was", "born", "dragon", "and", "he", "was", "good", "so", "he", "created", "this", "world");

            m.Add("22834444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444435");
            m.Add("22834444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444435");
            //m.Add("22834444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444435");
            //m.Add("22834444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444435");
            //m.Add("22834444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444435");
            //m.Add("22834444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444435");

            Thread game = new Thread(() =>
            {
                while (true)
                {
                    player.StartControl();
                    Console.SetCursorPosition(0, 0);
                    Displayer.Display(Maps.MapDictionary["Test Map"], m);
                    Thread.Sleep(1);
                }
            });
            game.Start();

        }


    }
}
