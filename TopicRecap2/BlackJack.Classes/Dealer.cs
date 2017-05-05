using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    public class Dealer : Player
    {
        public override int Hit(Deck currentDeck)
        {
            
            Hand.Add(currentDeck.Extract());
            if (Hand.Last().Rank == Rank.Ace)
            {
                if (Points + Hand.Last().Point <= 21)
                {
                    Hand.Last().Point = 11;
                }

            }
            Points = Points + Hand.Last().Point;
            return Points;
        }
    }
}
