using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class PlayerGame : Card
    {
        private int points;

        public PlayerGame(Rank rank, Suit suit) : base(rank, suit)
        {
            points = getPoints();
        }
    }
}