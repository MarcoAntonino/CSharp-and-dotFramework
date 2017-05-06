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
        private bool Natural { get; set; }
        public bool IsBust { get; set; }

        public Player ()
        {
            this.Points = 0;
            this.Hand = new List<Card>();
            this.Natural = false;
        }

        public abstract int Hit(Deck currentDeck);

        
       
                

        public override string ToString()
        {
            return string.Concat("Hand: ");
            foreach (Card c in Hand)
            {
                Console.WriteLine(c);
            }
        }

        public void IsNaturalBJ(Player CurrentPlayer)
        {
            if (CurrentPlayer.Points == 21 && CurrentPlayer.Hand.Count == 2)
                CurrentPlayer.Natural = true;
        }
      
    }
}
