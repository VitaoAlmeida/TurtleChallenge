using System.Collections.Generic;
using TurtleChallenge.ConsoleApp.Config;

namespace TurtleChallenge.ConsoleApp.Mock
{
    public class MocFile
    {
        public static Configuration Config()
        {
            ObjectBoard board = new ObjectBoard();
            board.X = 4;
            board.Y = 5;

            ObjectBoard turtle = new ObjectBoard();
            turtle.X = 0;
            turtle.Y = 1;
            turtle.dir = "North";

            ObjectBoard exit = new ObjectBoard();
            exit.X = 4;
            exit.Y = 2;

            List<ObjectBoard> mines = new List<ObjectBoard>();
            mines.Add(new ObjectBoard()
            {
                X = 1,
                Y = 1
            });
            mines.Add(new ObjectBoard()
            {
                X = 1,
                Y = 3
            });
            mines.Add(new ObjectBoard()
            {
                X = 3,
                Y = 3
            });

            Configuration config = new Configuration();
            config.Board = board;
            config.Turtle = turtle;
            config.Exit = exit;
            config.Mines = mines;

            return config;
        }


        public static List<string> Instructions_Go_to_exit()
        {
            List<string> instructions = new List<string>();

            instructions.Add("m");
            instructions.Add("r");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("r");
            instructions.Add("m");
            instructions.Add("m");

            return instructions;
        }
    }
}
