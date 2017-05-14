using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    [Serializable]
    public class DealerPointsOutOfRangeException : ApplicationException
    {
        public DealerPointsOutOfRangeException(string message) : base(message)
        {
        }

        public DealerPointsOutOfRangeException() { }
    }
}
