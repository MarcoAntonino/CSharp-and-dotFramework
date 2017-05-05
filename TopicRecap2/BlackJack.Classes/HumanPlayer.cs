using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    public class HumanPlayer : Player
    {
        public string Name { get; set; }
        public int Stack { get; set; }
        public int Bet { get; set; }



    public HumanPlayer (string name)
        {
            this.Name = name;
            this.Stack = 1000;
            this.Bet = 0;

        }
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

        
        public void SetBet(int currentBet)
        {
            Bet = currentBet;            
            
            Stack = Stack - Bet;

            

            //if (Bet < Stack)
            //    return Bet;
            //else
            //{
            //    Console.WriteLine("Non puoi scommettere quello che non hai");
            //    return SetBet(currentStack);
            //}
        }

        

    }
}
