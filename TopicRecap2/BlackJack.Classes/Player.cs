using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    public abstract class Player
    {
        public int Points { get; set; }
        public List<Card> Hand { get; set; }
        public bool Natural { get; set; }

        public Player ()
        {
            this.Points = 0;
            this.Hand = new List<Card>();
            this.Natural = false;

        }

        public int Hit(Deck currentDeck)
        {
            Hand.Add(currentDeck.Extract());
            Points = Points+Hand.Last().Point;
            return Points;
        }

        

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
