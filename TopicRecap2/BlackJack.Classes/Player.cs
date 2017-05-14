using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    /// <summary>
    /// This abstract class is the father class for the player classes. Two classes inherit from this class:
    ///  - HumanPlayer
    ///  - Dealer
    ///  
    /// The class properties are:
    /// - Points: the current point of the player in the current turn
    /// - Hand: a list of Card objects which ripresents the current hand of the player in the current turn
    /// - IsBust: a bool value which is true when the Points of the player for the current turn are >21
    /// </summary>
    public abstract class Player
    {

        public int Points { get; set; }
        public List<Card> Hand { get; set; }
        public bool IsBust { get; set; }

        public Player ()
        {
            this.Points = 0;
            this.Hand = new List<Card>();
        }

        /// <summary>
        /// Abstract method which allowa the player to extract a card from the current deck
        /// </summary>
        /// <param name="currentDeck">The current deck used in the game</param>
        /// <returns>A int value referring to the player current Points</returns>
        public abstract int Hit(Deck currentDeck);

        public override string ToString()
        {
            return string.Concat("Hand: ");
            foreach (Card c in Hand)
            {
                Console.WriteLine(c);
            }
        }

              
    }
}
