using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Player
    {
        private int _score = 0;
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }
        public string Name { get; set; }
        public string Choice { get; set; }
        public Player(string name)
        {
            Name = name;
        }
    }
}
