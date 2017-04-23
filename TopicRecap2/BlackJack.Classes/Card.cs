using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    public class Card
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }
        public int Point { get; set; }
       
        public Card(Rank newRank, Suit newSuit)
        {
            this.Rank = newRank;
            this.Suit = newSuit;
            if (this.Rank<=Rank.Ten)
            {
                Point = 1;
                Point = Point + (this.Rank - Rank.Ace);
            }
            else
            {
                Point = 10;
            }

        }

       

        public override string ToString()
        {
            return string.Concat("Rank: ", Rank, " Suit: ", Suit, " Point: ", Point);
        }
    }
}
