using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Classes;


namespace BlackJack.CLI
{
    public partial class AceValueChoice : Form
    {
        public int aceValue = 1;
        
        
        public AceValueChoice()
        {
            InitializeComponent();
        }

        public void rbtnOne_CheckedChanged(object sender, EventArgs e)
        {

            this.aceValue = 1;
        }

        public void rbtnEleven_CheckedChanged(object sender, EventArgs e)
        {

            this.aceValue = 11;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int GetAceValue()
        {
            return aceValue;
        }

        private void AceValueChoice_Load(object sender, EventArgs e)
        {

        }
    }
}
