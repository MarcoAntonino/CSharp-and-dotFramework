using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public Card(Rank rank, Suit suit)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public int getPoints()
        {
            if ((int)Rank+1 < 10)
                return (int)Rank+1;
            else return 10;
        }
    }
}
