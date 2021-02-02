using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnviroment.Helpers.Implementations
{
    public static class Parser
    {
        public static List<char> Brackets = new List<char>()
        {
            '\"',
            '{',
            '}',
            '[',
            ']',
            '<',
            '>',
            '(',
            ')'
        };
        public static List<char> UnusedSymbols = new List<char>()
        {
            ' ',
            '\n'
        };

        public static string[] ParseLine(string line)
        {
            List<string> words = new List<string>();

            int firstPosition = 0;

            bool startBracket = false;

            for (int i = 0; i < line.Length; i++)
            {

                bool compare = (!IsOneOf(line[i], UnusedSymbols) || startBracket);
                if (compare)
                {

                }
                else
                {
                    if (i - firstPosition > 1)
                    {
                        words.Add(line.Substring(firstPosition + 1, i - firstPosition + 1));
                    }
                    firstPosition = i;
                }
            }


            return words.ToArray();
        }

        private static bool IsOneOf(char line, List<char> list)
        {
            foreach (char item in list)
            {
                if (item == line)
                    return true;
            }
            return false;
        }
    }
}
