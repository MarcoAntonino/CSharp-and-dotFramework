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
        private List<PictureBox> playerHandPictures = new List<PictureBox>();
        public string machineImagePath = "C:\\Users\\NewMarco\\Documents\\ITS ICT\\CSharp-and-dotFramework\\TopicRecap2";
        int i = 1;

        public Form1()
        {
            InitializeComponent();
            lblP1Name.Text = p1.Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            

        }



        Deck d1 = new Deck();
        HumanPlayer p1 = new HumanPlayer("Marco");
        
        
        
          

        private void button1_Click(object sender, EventArgs e)
        {

            p1.Hit(d1);
            Card c2 = d1.Extract();
            //MessageBox.Show(c2.ToString());
            textBox1.Text=c2.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Hit_Click(object sender, EventArgs e)
        {
            // Funziona
            //d1.Shuffle();
            //p1.Hit(d1);
            //Image img = Image.FromFile(machineImagePath+"\\BlackJack.CLI\\Cards\\" + p1.Hand[0].Suit + "\\" + p1.Hand[0].Rank + ".jpg");
            //pictureBox1.Image = img;
            //playerHandPictures.Add(new PictureBox());
            //playerHandPictures[0].Image = img;
            //playerHandPictures[0].Left = 100;
            //playerHandPictures[0].Top = 50;
            //this.Controls.Add(playerHandPictures[0]);

            
            d1.Shuffle();
            p1.Hit(d1);
            playerHandPictures.Add(new PictureBox());
            playerHandPictures.Last().Image=Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + p1.Hand.Last().Suit + "\\" + p1.Hand.Last().Rank + ".jpg");
            playerHandPictures.Last().Size = new Size(74, 99);
            playerHandPictures.Last().Location=new Point(56+i,400);
            this.Controls.Add(playerHandPictures.Last());
            i=i+20;

        }

        private void lblPlayer1_Click(object sender, EventArgs e)
        {
            
        }

        

        //private void CreateControls()
        //{
        //    for (int i = 0; i<playerHandPictures.Count; i++)
        //    {
        //        var newPictureBox = new PictureBox();
        //        newPictureBox.Width = 75;
        //        newPictureBox.Height = 100;
        //        playerHandPictures[i] = SizeImage(newPictureBox, i);
        //    }
        //}

        //private PictureBox SizeImage(PictureBox pb, int i)
        //{
        //    Image img = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + p1.Hand[0].Suit + "\\" + p1.Hand[0].Rank + ".jpg");


        //}

    }
}
