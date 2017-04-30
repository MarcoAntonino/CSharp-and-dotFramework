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
            this.Stack = 100;
            this.Bet = 0;

        }

        public int SetBet(int currentStack)
        {
            
            while (Bet > Stack)
            {
                Console.WriteLine("Non puoi scommettere quello che non hai");
            }

            return Bet;



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
