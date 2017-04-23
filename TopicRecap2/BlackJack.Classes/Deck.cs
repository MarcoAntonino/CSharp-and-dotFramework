using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    public class Deck
    {
        List<Card> deck = new List<Card>();

        /*
         * Create a deck creating an object card for every suit and every rank
         */
         
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
