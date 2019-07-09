using System;
using System.Collections.Generic;
using System.Text;

namespace TurtleChallenge.ConsoleApp.Classes.Objects
{
    public class Mine
    {
        private readonly int _x;
        private readonly int _y;

        public Mine(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

    }
}
