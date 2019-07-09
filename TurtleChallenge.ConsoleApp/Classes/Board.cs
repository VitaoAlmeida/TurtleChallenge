using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static TurtleChallenge.ConsoleApp.Classes.Commands.Rotate;

namespace TurtleChallenge.ConsoleApp.Classes
{
    public class Board
    {
        private int[,] _board;
        private int _turtlePositionX;
        private int _turtlePositionY;
        private Direction _turtleDirection;
        private int _exitPositionX;
        private int _exitPositionY;

        public Board(int x, int y)
        {
            _board = new int[x, y];
            _turtlePositionX = 0;
            _turtlePositionY = 1;
            _turtleDirection = Direction.North;
            _exitPositionX = 4;
            _exitPositionY = 2;
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            // TODO load configuration by a file config (turtle position, mines and exit, turtle direction)
        }



    }
}
