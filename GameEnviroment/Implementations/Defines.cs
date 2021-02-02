using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GameEnviroment.Helpers.Implementations;
using Configurations;

namespace GameEnviroment.Implementations
{
    public class Defines
    {
        private Dictionary<string, string> _definesDictionary;

        public Defines()
        {
            _definesDictionary = new Dictionary<string, string>();
            LoadDefines();
        }

        public void LoadDefines()
        {
            string[] defines = File.ReadAllLines(StandartDefines.DefinesPath);

            SetDefines(defines);
        }

        public string this[string i]
        {
            get => _definesDictionary[i];
            private set => _definesDictionary[i] = value;
        }

        private void SetDefines(string[] defines)
        {
            foreach(string line in defines)
            {
                if (line[0] != ' ' || line[0] != '#')
                {
                    string[] splittedLine = line.Split(' ');

                    _definesDictionary[splittedLine[0]] = splittedLine[2];
                }
            }
        }
    }
}
