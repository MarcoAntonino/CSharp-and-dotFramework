using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    class PlayerPointsOutOfRangeException : Exception
    {
        public PlayerPointsOutOfRangeException(string message) : base(message)
        {
        }
    }
}
