using TurtleChallenge.ConsoleApp.Classes.Objects;

namespace TurtleChallenge.ConsoleApp.Classes.Action
{
    public static class CommandBoard
    {
        public static void Rotate(this Turtle turtle)
        {
            switch (turtle.Dir.ToLower())
            {
                case "north":
                    turtle.Dir = "east";
                    break;
                case "east":
                    turtle.Dir = "south";
                    break;
                case "south":
                    turtle.Dir = "west";
                    break;
                case "west":
                    turtle.Dir = "north";
                    break;
            }

        }

        public static void Forward(this Turtle turtle)
        {
            switch (turtle.Dir.ToLower())
            {
                case "north":
                    turtle.YNext++;
                    break;
                case "east":
                    turtle.XNext++;
                    break;
                case "south":
                    turtle.YNext--;
                    break;
                case "west":
                    turtle.XNext--;
                    break;
            }
        }

        public static void Instruction(string command)
        {
            switch (command)
            {
                case "m":
                    this.Rotate();
                    break;
                case "r":
                    this.Forward();
                    break;
                default:
                    break;
            }
        }

    }
}
