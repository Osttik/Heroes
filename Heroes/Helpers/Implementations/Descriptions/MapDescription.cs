using Heroes.Helpers.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Helpers.Implementations.Descriptions
{
    public class MapDescription : IDescription, IEnumerable
    {
        public string MapName { get; set; }
        
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
            string mainDescription = "";
            mainDescription += GetLenghtLineToConsoleSize(_leftUpLine, _rightUpLine) + _end;
            mainDescription += _lineBegin + MapName + "\"";

            return mainDescription;
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
            Queue<string> words = new Queue<string>();

            while (true)
            {

            }

            return pretifyiedLines.ToArray();
        }

        public void Add(string line)
        {
            _mapDescription.Add(line);
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
