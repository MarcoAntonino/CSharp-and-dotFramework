using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    public class PlayerOne : Player
    {
        public string Name { get; set; }

        public PlayerOne (string name)
        {
            this.Name = name;
        }


    }
}
