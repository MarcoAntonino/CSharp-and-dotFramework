using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    [Serializable]
    public class Game
    {
        public DateTime StartDate { get;set; }
        public DateTime EndDate { get; set; }
        public int PlayerPoints { get; set; }
        public int DealerPoints { get; set; }
        public string WinnerName { get; set; }

    }
}
