using System.Collections.Generic;
using TurtleChallenge.ConsoleApp.Config;

namespace TurtleChallenge.ConsoleApp.Mock
{
    public class MocFile
    {
        public static Configuration Config()
        {
            ObjectBoard board = new ObjectBoard();
            board.X = 5;
            board.Y = 4;

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
                X = 3,
                Y = 1
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


        public static List<string> Instructions_Go_To_Exit()
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


        public static List<string> Instructions_Out_Of_Bound()
        {
            List<string> instructions = new List<string>();

            instructions.Add("r");
            instructions.Add("r");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("m");

            return instructions;
        }


        public static List<string> Instructions_Hit_Mine()
        {
            List<string> instructions = new List<string>();

            instructions.Add("r");
            instructions.Add("m");

            return instructions;
        }

        public static List<string> Instructions_Still_In_Danger()
        {
            List<string> instructions = new List<string>();

            instructions.Add("m");
            instructions.Add("r");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("r");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("r");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("r");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("r");
            instructions.Add("m");
            instructions.Add("m");
            instructions.Add("r");
            instructions.Add("m");
            instructions.Add("m");

            return instructions;
        }
    }
}
