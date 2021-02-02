using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Implementations
{
    public class Position
    {
        private int _x;
        private int _y;
        private int _maxX;
        private int _maxY;

        public int XPosition
        {
            get => _x;
            set
            {
                if (value >= 0 && value < _maxX)
                {
                    _x = value;
                }
            }
        }
   
        public int YPosition
        {
            get => _y;
            set
            {
                if (value >= 0 && value < _maxY)
                {
                    _y = value;
                }
            }
        }

        public Position(): this(0, 0)
        {
            _maxX = 0;
            _maxY = 0;
        }

        public Position(int x, int y)
        {
            XPosition = x;
            YPosition = y;
            _maxX = 0;
            _maxY = 0;
        }

        public Position(int x, int y, int maxX, int maxY) : this(x, y)
        {
            _maxX = maxX;
            _maxY = maxY;
        }

        public void SetMaxCoordinations(int maxX, int maxY)
        {
            _maxX = maxX;
            _maxY = maxY;
        }
    }
}
