using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public Rank Value { get; set; }
        public Suit Seed { get; set; }
        public Point Point { get; set; }
    }
}
