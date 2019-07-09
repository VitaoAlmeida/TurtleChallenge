using TurtleChallenge.ConsoleApp.Classes.Action;

namespace TurtleChallenge.ConsoleApp.Classes.Objects
{
    public class Turtle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Dir { get; set; }

        public void Instruction(string command)
        {
            switch (command)
            {
                case "m":
                    this.Forward();
                    break;
                case "r":
                    this.Rotate(); 
                    break;
                default:
                    break;
            }
        }


    }
}
