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
            MatchesOfDay.DataSource = loadMatchList();
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
    }
}
