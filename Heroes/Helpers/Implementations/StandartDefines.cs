using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Helpers.Implementations
{
    public class StandartDefines
    {
        #region Public
        public static readonly float MinHealth;
        public static readonly float MinMana;
        public static readonly float MinEndurance;

        #region Attributes
        public static readonly float MinAgility;
        public static readonly float MinInteligence;
        public static readonly float MinStrenght;
        #endregion Attributes

        public static readonly string MapZero;
        public static readonly string DefinesPath;
        public static readonly string WhiteString;
        #endregion Public

        #region Private
        private static string DefinesFile { get; set; }
        #endregion Private

        static StandartDefines()
        {
            MinHealth = 200;
            MinMana = 200;
            MinEndurance = 200;

            MinAgility = 1;
            MinInteligence = 1;
            MinStrenght = 1;

            MapZero = "Zero";

            DefinesFile = "Defines.txt";
            WhiteString = "You was trying to get Unreal string";

            DefinesPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Heroes\" + DefinesFile;
        }

        public static void Save()
        {
            Directory.CreateDirectory(DefinesPath.Substring(0, DefinesPath.Length - DefinesFile.Length));
            FileStream fs = File.Create(DefinesPath);
            fs.Close();

            string[] defines = GetAllDefinesStrings();

            File.WriteAllLines(DefinesPath, defines);
        }

        private static string[] GetAllDefinesStrings()
        {
            List<string> definesStrings = new List<string>();

            definesStrings.Add("MinHealth = 200");
            definesStrings.Add("MinMana = 200");
            definesStrings.Add("MinEndurance = 200");
            definesStrings.Add("MinAgility = 1");
            definesStrings.Add("MinInteligence = 1");
            definesStrings.Add("MinStrenght = 1");
            definesStrings.Add("MapZero = Zero");
            definesStrings.Add("WhiteString = You was trying to get Unreal string");

            return definesStrings.ToArray();
        }
    }
}
