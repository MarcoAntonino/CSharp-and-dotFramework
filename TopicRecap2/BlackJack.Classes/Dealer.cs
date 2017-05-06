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
                if (Points<10)
                {
                    Hand.Last().Point = 11;
                }
                else
                {
                    Hand.Last().Point = 1;
                }

            }
            Points = Points + Hand.Last().Point;
            if (Points > 21)
            {
                IsBust = true;
                throw new DealerPointsOutOfRangeException(string.Format("Il dealer ha superato il punteggio di 21"));
            }
                
            return Points;
        }
    }
}
