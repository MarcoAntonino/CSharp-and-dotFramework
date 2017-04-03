using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es12Matches
{
    public class MatchLive : Match
    {
        public bool IsLive { get; set; }
        public bool IsFinished { get; set; }
        public int Minute { get; set; }


    }
}
