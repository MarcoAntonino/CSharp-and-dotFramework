using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    /// <summary>
    /// The class cards is the base class for the card object.
    /// </summary>

    public class Card
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }
        public int Point { get; set; }

        /// <summary>
        /// The constructor takes 2 arguments and calculate card's points as you can see in the code
        /// </summary>
        /// <param name="newRank"></param>
        /// <param name="newSuit"></param>
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
