using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    /// <summary>
    /// The class deck is an list of the objects card.
    /// </summary>
    public class Deck
    {
        List<Card> deck = new List<Card>();

        
         
        public Deck()
        {
            foreach (Suit Suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank Rank in Enum.GetValues(typeof(Rank)))
                {
                    deck.Add(new Card(Rank, Suit));
                }
            }
        }

        /// <remarks>
        /// As its name says, this method shuffles the members of the deck list using a random value to choose
        /// which cards shuffle and a temporary card object to make the change of position possibile 
        /// </remarks>
        public void Shuffle()
        {
            Random rnd = new Random();
            Card tmp;

            for (int i = 0; i < deck.Count; i++)
            {
                int id1 = rnd.Next(0, deck.Count);
                int id2 = rnd.Next(0, deck.Count);
                tmp = deck[id1];
                deck[id1] = deck[id2];
                deck[id2] = tmp;
            }
        }

        /// <remarks>
        /// This method create a new object Card, called extractedCard which is the first card in the deck.
        /// Once the extractedCard is created, his copy is removed from the deck
        /// </remarks>
        /// <returns>A copy of the first card of the deck</returns>
        public Card Extract()

        {   
            Card extractedCard = deck.First();
            deck.Remove(deck.First());
            return extractedCard;
        }

        public override string ToString()
        {
            string msg = "";
            foreach (Card o in deck)
            {
                msg += o.Rank + " " + o.Suit + " " + o.Point + "\n";
            }

            return msg;
        }


    }
}
