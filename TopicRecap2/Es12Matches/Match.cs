using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es12Matches
{
    public class Match
    {

        public string AwayTeamName { get; set; }
        public string HomeTeamName { get; set; }
        public string CompetitionName { get; set; }
        public int IdMatch { get; set; }
        public DateTime MatchDate { get; set; }
        public int? ScoreAway { get; set; } // ? Può esser null
        public int? ScoreHome { get; set; }
        public string WinTeamNAme { get; set; }
        

    }
}
