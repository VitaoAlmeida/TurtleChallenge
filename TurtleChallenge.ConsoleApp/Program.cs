using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TurtleChallenge.ConsoleApp.Classes;
using TurtleChallenge.ConsoleApp.Config;

namespace TurtleChallenge.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            string configuration = null;
            string moves = null;

            if (args.Any())
            {
                if (args.Length >= 2)
                {
                    //Configuration
                    if (File.Exists(args[0]))
                    {
                        var input = File.OpenText(args[0]);
                        configuration = input.ReadToEnd();
                        
                    }
                    //Moves
                    if (File.Exists(args[1]))
                    {
                        var input = File.OpenText(args[1]);
                        moves = input.ReadToEnd();
                        
                    }
                }
            }

            ChallengeFacede challenge = new ChallengeFacede();
            challenge.ChallengeExecute(configuration, moves);

        }
    }
}
