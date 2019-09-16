using Heroes.GameEngine.Implementations;
using Heroes.GameEngine.Implementations.Controllers;
using Heroes.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Helpers.Implementations
{
    public static class Displayer
    {
        public static void Display(Map mapToDisplay, IDescription Description)
        {
            string mapString = MapDisplayController.GetDisplay(mapToDisplay);

            string descriptionString = Description.GetDescription();

            ConsoleDisplay(mapString, descriptionString);
        }

        private static void ConsoleDisplay(params string[] strings)
        {
            string mainString = "";
            foreach(string line in strings)
            {
                mainString += line;
            }

            Console.WriteLine(mainString);
        }
    }
}
