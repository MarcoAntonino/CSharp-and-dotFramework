using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    /// <summary>
    /// The dealer is the player controlled by the game itself.
    /// </summary>
    public class Dealer : Player
    {
        /// <summary>
        /// The Hit method takes as argument the current deck and adds to the hand of the dealer a card which is
        /// a copy of the first card of the deck.
        /// As you can see, there's an if construct which automatically determines the value of the ace evaluating
        /// the current points of the dealer hands.
        /// If dealer's points>21 throws a custom exception and switch to true the IsBust property
        /// </summary>
        /// <param name="currentDeck"></param>
        /// <returns>The current points of the dealer for current turn</returns>
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
