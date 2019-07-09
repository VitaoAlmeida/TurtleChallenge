using System;
using TurtleChallenge.ConsoleApp.Classes.Objects;

namespace TurtleChallenge.ConsoleApp.Classes
{
    public static class Validation
    {
        //Check if the next step is valid
        public static bool ValidatePosition(this Board board, int sequence, Turtle turtle)
        {

            //Verify the board limit
            if (turtle.X >= board.XLength || turtle.Y >= board.YLength ||
                turtle.X < 0 || turtle.Y < 0)
            {
                Console.WriteLine("Sequence " + sequence + ": Out of bounds!");
                return false;
            }

            //Verify the mine hit
            foreach (var item in board.Mines)
            {
                if (turtle.X == item.X && turtle.Y == item.Y)
                {
                    Console.WriteLine("Sequence " + sequence + ": Mine hit!");
                    return false;
                }
            }


            //Verify the exit
            if (turtle.X == board.Exit.X && turtle.Y == board.Exit.Y)
            {
                Console.WriteLine("Sequence " + sequence + ": Success!");
                return false;
            }

            return true;
        }
    }
}
