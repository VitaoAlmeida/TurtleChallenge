using System;
using System.Collections.Generic;
using System.Text;
using TurtleChallenge.ConsoleApp.Classes.Commands.Base;
using TurtleChallenge.ConsoleApp.Interfaces.Commands;

namespace TurtleChallenge.ConsoleApp.Classes.Commands
{
    public class Rotate : Command, IRotate
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public enum Direction
        {
            North,
            South,
            West,
            East
        }
    }
}
