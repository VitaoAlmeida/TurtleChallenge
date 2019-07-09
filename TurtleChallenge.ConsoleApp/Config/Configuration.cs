using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurtleChallenge.ConsoleApp.Config
{
    public class Configuration
    {
        [JsonProperty("Board")]
        public ObjectBoard Board { get; set; }

        [JsonProperty("Turtle")]
        public ObjectBoard Turtle { get; set; }

        [JsonProperty("Exit")]
        public ObjectBoard Exit { get; set; }

        [JsonProperty("Mines")]
        public List<ObjectBoard> Mines { get; set; }

        [JsonProperty("Instructions")]
        public List<String> Instructions { get; set; }

    }
}
