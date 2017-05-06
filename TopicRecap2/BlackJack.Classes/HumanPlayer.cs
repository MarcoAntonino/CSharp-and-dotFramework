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
        public double Stack { get; set; }
        public double Bet { get; set; }



    public HumanPlayer (string name)
        {
            this.Name = name;
            this.Stack = 1000;
            this.Bet = 0;

        }
        public override int Hit(Deck currentDeck)
        {
            Hand.Add(currentDeck.Extract());
           
            Points = Points + Hand.Last().Point;
            if (Points > 21)
            {
                IsBust = true;
                throw new PlayerPointsOutOfRangeException(string.Format("Il giocatore ha superato il punteggio di 21"));
            }
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
