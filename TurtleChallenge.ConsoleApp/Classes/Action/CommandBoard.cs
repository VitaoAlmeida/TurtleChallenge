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
                    turtle.Y--;
                    break;
                case "east":
                    turtle.X++;
                    break;
                case "south":
                    turtle.Y++;
                    break;
                case "west":
                    turtle.X--;
                    break;
            }
        }

    }
}
