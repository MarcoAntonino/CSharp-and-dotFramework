using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        List<Card> deck = new List<Card>();
        
        public Deck(int numCards)
        {
            int rank = 0;
            int suit = 0;
            for(int i = 0; i<numCards; i++)
            {
                deck.Add(new Card((Rank)rank, (Suit)suit));
                rank++;
                if (rank > 12)  //cambia seme
                {
                    rank = 0;
                    suit++;
                    if (suit > 3)   //ricomincia da nuovo mazzo
                        suit = 0;
                }
            }
        }

        public void shuffle(int num)
        {
            Random rnd = new Random();
            Card tmp;

            for (int i=0; i<num; i++)
            {
                int id1 = rnd.Next(0, deck.Count);
                int id2 = rnd.Next(0, deck.Count);
                tmp = deck[id1];
                deck[id1] = deck[id2];
                deck[id2] = tmp;
            }
        }

        public Card extract(int position)
        {
            Card newCard = deck.First();
            deck.Remove(deck.First());
            //Card newCard = deck[position];
            position++;
            return newCard;
        }

        public override string ToString()
        {
            string msg="";
            foreach(Card o in deck)
            {
                msg += o.Rank + " " + o.Suit + "\n";
            }

            return msg;
        }
    }
}
