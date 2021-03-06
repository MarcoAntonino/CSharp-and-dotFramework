﻿using System;
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
    /// <summary>
    /// This form it's generated every time a HumanPlayer extracts an ace from the deck and allows to the HumanPlayer to manually set the points of the ace card 
    /// </summary>
    public partial class AceValueChoice : Form
    {
        public int aceValue;
        public Form1 frm1;
        
        
        public AceValueChoice()
        {
            InitializeComponent();
            
        }

        public void rbtnOne_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnOne.Checked)
                this.aceValue = 1;
        }

        public void rbtnEleven_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOne.Checked)
                this.aceValue = 11;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            
            if (rbtnOne.Checked)
            {
                this.aceValue = 1;

            }
            else
            {
                this.aceValue = 11;
               
            }
            this.Close();
            this.DialogResult = DialogResult.OK;
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
