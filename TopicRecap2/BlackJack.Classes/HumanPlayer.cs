using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    /// <summary>
    /// This class is controlled by the client of the program and has 3 new properties:
    ///  - name: the name of the player
    ///  - Stack: the amount of chips for the player
    ///  - bet: the current bet for the current turn made by the player
    /// 
    /// </summary>
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

        /// <remark>
        /// The Hit method takes as argument the current deck and adds to the hand of the HumanPlayer a card which is
        /// a copy of the first card of the deck.
        /// If the HumanPlayer's points>21 throws a custom exception and switch to true the IsBust property
        /// </remark>
        /// <param name="currentDeck"></param>
        /// <returns></returns>
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


        /// <summary>
        /// This method takes as argument an int value which is the HumanPlayer's current bet for the current turn.
        /// It subtracts the value to the Stack.
        /// In the future will be implemented a function to check if the HumanPlayer can afford the bet.
        /// </summary>
        /// <param name="currentBet"></param>
        public void SetBet(int currentBet)
        {
            Bet = currentBet;            
            
            Stack = Stack - Bet;                  

           
        }

        

    }
}
