using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TurtleChallenge.ConsoleApp.Classes.Objects;
using TurtleChallenge.ConsoleApp.Config;
using TurtleChallenge.ConsoleApp.Mock;

namespace TurtleChallenge.ConsoleApp.Classes
{

    public class ChallengeFacede
    {
        private Board _board;
        private Turtle _turtle;


        public void ChallengeExecute(string configuration, string moves)
        {

            Configuration initialConfiguration = JsonConvert.DeserializeObject<Configuration>(configuration);
            List<List<string>> allMoves = JsonConvert.DeserializeObject<List<List<string>>>(moves);

            //List<List<string>> allInstructions = new List<List<string>>();
            //allInstructions.Add(MocFile.Instructions_Go_To_Exit());
            //allInstructions.Add(MocFile.Instructions_Out_Of_Bound());
            //allInstructions.Add(MocFile.Instructions_Hit_Mine());
            //allInstructions.Add(MocFile.Instructions_Still_In_Danger());

            LoadInitialConfiguration(initialConfiguration);

            for (int j = 0; j < allMoves.Count; j++)
            {
                LoadInitialTurtlePosition(initialConfiguration);

                bool stillInDanger = true;
                
                var seq = j + 1;
                for (int i = 0; i < allMoves[j].Count; i++)
                {
                    _turtle.Instruction(allMoves[j][i]);

                    if (!_board.ValidatePosition(seq, _turtle))
                    {
                        stillInDanger = false;
                        i = allMoves[j].Count;
                    }

                }

                if (stillInDanger)
                    Console.WriteLine("Sequence " + seq + ": Still in danger!");
            }

        }

        #region LoadConfiguration
        /// <summary>
        /// Load configuration from the file
        /// </summary>
        /// <param name="initialConfiguration"></param>
        private void LoadInitialConfiguration(Configuration initialConfiguration)
        {
            _turtle = new Turtle()
            {
                X = initialConfiguration.Turtle.X,
                Y = initialConfiguration.Turtle.Y,
                Dir = initialConfiguration.Turtle.dir
            };

            Exit exit = new Exit(initialConfiguration.Exit.X, initialConfiguration.Exit.Y);
            List<Mine> mines = new List<Mine>();
            for (int i = 0; i < initialConfiguration.Mines.Count; i++)
            {
                mines.Add(new Mine(initialConfiguration.Mines[i].X, initialConfiguration.Mines[i].Y));
            }

            _board = new Board(initialConfiguration.Board.X, initialConfiguration.Board.Y, exit, mines);

        }

        /// <summary>
        /// Load the Initial position of the turtle
        /// </summary>
        /// <param name="initialConfiguration"></param>
        private void LoadInitialTurtlePosition(Configuration initialConfiguration)
        {
            _turtle = new Turtle()
            {
                X = initialConfiguration.Turtle.X,
                Y = initialConfiguration.Turtle.Y,
                Dir = initialConfiguration.Turtle.dir
            };
        }
        #endregion
    }
}
