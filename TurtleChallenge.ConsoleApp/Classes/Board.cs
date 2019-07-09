using System;
using System.Collections.Generic;
using TurtleChallenge.ConsoleApp.Classes.Objects;

namespace TurtleChallenge.ConsoleApp.Classes
{
    public class Board
    {
        private readonly int _xLength;
        private readonly int _yLength;
        public List<Mine> Mines { get; set; }
        public Exit Exit { get; set; }

        public int XLength { get { return _xLength; } }
        public int YLength { get { return _yLength; } }

        public Board(int xLength, int yLength, Exit exit, List<Mine> mines)
        {
            _xLength = xLength;
            _yLength = yLength;
            Mines = mines;
            Exit = exit;
        }




       private void Print()
        {
            int x = _xLength;
            int y = _yLength;

            for (int i = 0; i < x; i++)
            {
                //Line
                Console.Write(" ");
                for (int k = 0; k < y; k++)
                {
                    Console.Write("---- ");
                }
                Console.WriteLine("");

                //Column
                Console.Write("|  ");
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  |  ");
                }
                Console.WriteLine("");
            }

            //Last line
            Console.Write(" ");
            for (int k = 0; k < y; k++)
            {
                Console.Write("---- ");
            }
            Console.WriteLine("");

        }

    }
}
