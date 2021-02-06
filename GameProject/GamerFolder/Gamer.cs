using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Gamer
    {
        public string TcNO { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public List<Game> gamespl { get; set; }
    }
}
