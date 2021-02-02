using Configurations;
using GameEnviroment.Helpers.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnviroment.Helpers.Implementations.Descriptions
{
    public class MapDescription : IDescription, IEnumerable
    {
        public string MapName { get; set; }
        public string Description { get; set; }

        public int DescriptionLenght { get => _mapDescription.Count; }

        private List<string> _mapDescription { get; set; } = new List<string>();
        private string _lineBegin = "   World \"";
        private string _end = "\n";

        private char _lenghtLine = '═';
        private char _heigthLine = '║';
        private char _leftDownLine = '╚';
        private char _rightDownLine = '╝';
        private char _leftUpLine = '╔';
        private char _rightUpLine = '╗';
        private char _leftHigthLine = '╣';
        private char _rightHigthLine = '╠';

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < _mapDescription.Count)
                    return _mapDescription[i];
                return StandartDefines.WhiteString;
            }

            set
            {
                if (i >= 0 && i < _mapDescription.Count)
                    _mapDescription[i] = value;
            }
        }

        public string GetDescription()
        {
            if (Description == null || Description.Length == 0)
            {
                string mainDescription = "";
                mainDescription += GetLenghtLineToConsoleSize(_leftUpLine, _rightUpLine);
                mainDescription += GetPretifyLine(_lineBegin, MapName, "\"");

                string[] description = PretifyText(_mapDescription.ToArray());
                foreach (var item in description)
                {
                    mainDescription += item;
                }

                mainDescription += GetLenghtLineToConsoleSize(_leftDownLine, _rightDownLine);

                Description = mainDescription;
                return mainDescription;
            }
            return Description;
        }

        private string GetLenghtLineToConsoleSize(char begin, char end)
        {
            string line = "" + begin;
            for (int i = 0; i < Console.WindowWidth - 2; i++)
            {
                line += _lenghtLine;
            }
            line += end;

            return line;
        }

        private string[] PretifyText(string[] text)
        {
            List<string> pretifyiedLines = new List<string>();
            List<string> words = new List<string>();

            int currentWord = 0;
            int currentLength = 0;

            while (true)
            {

                if (currentLength + text[currentWord].Length + 3 < Console.WindowWidth)
                {
                    words.Add(text[currentWord]);
                    currentLength += text[currentWord].Length + 1;
                    currentWord++;
                }
                else
                {
                    if (currentLength == 0)
                    {
                        break;
                    }
                    pretifyiedLines.Add(GetPretifyLine(words.ToArray()));
                    currentLength = 0;
                    words.Clear();
                }

                if (currentWord >= text.Length)
                {
                    if (currentLength != 0)
                    {
                        pretifyiedLines.Add(GetPretifyLine(words.ToArray()));
                    }

                    break;
                }
            }

            return pretifyiedLines.ToArray();
        }

        private string GetPretifyLine(params string[] lines)
        {
            string pretifiedLine = _heigthLine + "";

            foreach (var item in lines)
            {
                pretifiedLine += " " + item;
            }

            pretifiedLine += GetLineFromCharacterToSize(" ", Console.WindowWidth - pretifiedLine.Length - 1);

            pretifiedLine += _heigthLine;

            return pretifiedLine;
        }

        private string GetLineFromCharacterToSize(string character, int size)
        {
            int counter = 0;
            string characterLine = string.Empty;

            while (counter < size)
            {
                for (int i = 0; i < character.Length; i++, counter++)
                {
                    if (counter >= size)
                        break;

                    characterLine += character[i];
                }
            }

            return characterLine;
        }

        public void Add(params string[] lines)
        {
            foreach (var line in lines)
            {
                _mapDescription.Add(line);
            }
        }

        public void Remove(int i)
        {
            _mapDescription.RemoveAt(i);
        }

        public IEnumerator GetEnumerator()
        {
            return _mapDescription.GetEnumerator();
        }
    }
}
