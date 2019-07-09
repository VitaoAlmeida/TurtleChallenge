using System;
using System.Collections.Generic;
using System.Text;

namespace TurtleChallenge.ConsoleApp.Classes
{
    public class Direction
    {
        
        public const string North = "North";
        public const string South = "South";
        public const string West = "West";
        public const string East = "East";

        public enum EnumDirection
        {
            North,
            South,
            West, 
            East
        }

        readonly string _value;

        public Direction(string value)
        {
            this._value = value;
        }


        public static implicit operator string(Direction d)
        {
            return d._value;
        }
        public static implicit operator Direction(string d)
        {
            return new Direction(d);
        }


    }
}
