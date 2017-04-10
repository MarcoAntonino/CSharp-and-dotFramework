using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;

namespace Es12Matches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //MatchesOfDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //List<Match> matches = loadMatchList();
            //var m = (from m in matches
            //         orderby m.IdMatch
            //         select new
            //         {
            //             IdMatch = m.IdMatch,
            //             MatchName = string.Concat(m.HomeTeamName, " vs ", m.AwayTeamName),
            //             MatchDate = m.MatchDate.ToString("yyyy-MM-dd HH:mm")
            //         }
            //        ).ToList();

            MatchesOfDay.DataSource = loadMatchList().Select(m => new
            {
                IdMatch = m.IdMatch,
                MatchName = string.Concat(m.HomeTeamName, " vs ", m.AwayTeamName),
                MatchDate = m.MatchDate.ToString("yyyy-MM-HH:mm")
            }) .OrderBy(mbox => mbox.IdMatch).ToList();
        }

        private string readingMatches()
        {
            using (TextReader fs = new StreamReader(@"C:\Users\antoninom\Documents\cSharp\CSharp-and-dotFramework\es12File\matches_today.json"))
            {
                return fs.ReadToEnd();
            }
        }

        private List <Match> loadMatchList() //se è private camelCase, se è public PascalCase
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            MatchesList ml = js.Deserialize<MatchesList>(readingMatches());
            return ml.Matches;

        }

        private void btLoadLiveMatches_Click(object sender, EventArgs e)
        {
            var liveMatchesList = LoadLiveMatchList();
            
        }
    }
}
