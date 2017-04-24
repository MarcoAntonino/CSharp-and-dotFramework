using BlackJack.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack.CLI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        Card c1 = new Card(Rank.Ten, Suit.Spades);
        Deck d1 = new Deck();
        PlayerOne marco = new PlayerOne("Marco");
        
        
          

        private void button1_Click(object sender, EventArgs e)
        {
            d1.Shuffle();
            marco.Hit(d1);
            Card c2 = d1.Extract();
            //MessageBox.Show(c2.ToString());
            textBox1.Text=c2.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        
    }
}
