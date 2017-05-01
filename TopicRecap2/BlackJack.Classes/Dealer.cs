using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    public class Dealer : Player
    {
        public override int Hit(Deck currentDeck)
        {
            if(Points<17)
                Hand.Add(currentDeck.Extract());
            Points = Points + Hand.Last().Point;
            return Points;
        }
    }
}
