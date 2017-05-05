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
        public List<PictureBox> dealerdHandPictures = new List<PictureBox>();
        public string machineImagePath = "C:\\Users\\NewMarco\\Documents\\ITS ICT\\CSharp-and-dotFramework\\TopicRecap2";
        int i = 1;
        int d = 1;

        Form popUp = new AceValueChoice();
        


        public Form1()
        {
            InitializeComponent();            
            lblP1Name.Text = p1.Name;
            txtP1Points.Text = p1.Points.ToString();
            txtPlayerBet.Text = p1.Bet.ToString();
            lblP1Stack.Text = p1.Stack.ToString();
            btnHit.Enabled = false;
            btnStand.Enabled = false;


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        Deck d1 = new Deck();
        HumanPlayer p1 = new HumanPlayer("Marco");
        Dealer de1 = new Dealer();

        private void button1_Click(object sender, EventArgs e)
        {

            p1.Hit(d1);
            Card c2 = d1.Extract();
            
            textBox1.Text=c2.ToString();
            NewRound();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Hit_Click(object sender, EventArgs e)
        {
            
            d1.Shuffle();
            p1.Hit(d1);
            PlayerAceValue();
            playerHandPictures.Add(new PictureBox());
            playerHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + p1.Hand.Last().Suit + "\\" + p1.Hand.Last().Rank + ".jpg");
            playerHandPictures.Last().Size = new Size(74, 99);
            playerHandPictures.Last().Location = new Point(56 + i, 400);
            this.Controls.Add(playerHandPictures.Last());
            playerHandPictures.Last().BringToFront();
            txtP1Points.Text = p1.Points.ToString();
            i = i + 20;

            if(Bust(p1)==true)
            {
                NewRound();
            }
                     

        }

        

        private void lblPlayer1_Click(object sender, EventArgs e)
        {
            
        }

                
        public void Hand()
        {
            
                        
        }

        public void FirstTwoRounds()
        {
            txtPlayerBet.Text = p1.Bet.ToString();
            lblP1Stack.Text = p1.Stack.ToString();

            //Primo giro
            d1.Shuffle();
            p1.Hit(d1);
            PlayerAceValue();
            playerHandPictures.Add(new PictureBox());
            playerHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + p1.Hand.Last().Suit + "\\" + p1.Hand.Last().Rank + ".jpg");
            playerHandPictures.Last().Size = new Size(74, 99);
            playerHandPictures.Last().Location = new Point(56 + i, 400);
            this.Controls.Add(playerHandPictures.Last());
            txtP1Points.Text = p1.Points.ToString();
            i = i + 20;

            de1.Hit(d1);
            dealerdHandPictures.Add(new PictureBox());
            dealerdHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + de1.Hand.Last().Suit + "\\" + de1.Hand.Last().Rank + ".jpg");
            dealerdHandPictures.Last().Size = new Size(74, 99);
            dealerdHandPictures.Last().Location = new Point(56 + d, 150);
            this.Controls.Add(dealerdHandPictures.Last());
            txtDPoints.Text = de1.Points.ToString();
            d = d + 20;

            //Secondo giro
            p1.Hit(d1);
            PlayerAceValue();
            playerHandPictures.Add(new PictureBox());
            playerHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + p1.Hand.Last().Suit + "\\" + p1.Hand.Last().Rank + ".jpg");
            playerHandPictures.Last().Size = new Size(74, 99);
            playerHandPictures.Last().Location = new Point(56 + i, 400);
            playerHandPictures.Last().Image.RotateFlip(RotateFlipType.Rotate180FlipXY);
            this.Controls.Add(playerHandPictures.Last());
            playerHandPictures.Last().BringToFront();
            txtP1Points.Text = p1.Points.ToString();
            i = i + 20;

            de1.Hit(d1);
            dealerdHandPictures.Add(new PictureBox());
            dealerdHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Resources\\Card_back1.png");
            dealerdHandPictures.Last().Size = new Size(74, 99);
            dealerdHandPictures.Last().Location = new Point(56 + d, 150);
            dealerdHandPictures.Last().SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(dealerdHandPictures.Last());
            dealerdHandPictures.Last().BringToFront();
            d = d + 20;

            btnBet1D.Enabled = false;
            btnBet5D.Enabled = false;
            btnBet25D.Enabled = false;
            btnBet100D.Enabled = false;
            btnHit.Enabled = true;
            btnStand.Enabled = true;

        }

        public void PlayerAceValue()
        {
            if (p1.Hand.Last().Rank == Rank.Ace)
            {
                AceValueChoice popUp = new AceValueChoice();
                popUp.frm1 = this;
                popUp.ShowDialog(this);
                p1.Hand.Last().Point = popUp.aceValue;
                p1.Points = (p1.Points - 1) + p1.Hand.Last().Point;
            }
        }

        //public void DealerAceValue()
        //{
        //    if (de1.Hand.Last().Rank == Rank.Ace)
        //    {
        //        if (de1.Points>10)
        //        {
        //            de1.Hand.Last().Point = 1;
        //        }
        //        else
        //        {
        //            de1.Hand.Last().Point = 1;

        //        }
        //        de1.Points = (de1.Points - 1) + de1.Hand.Last().Point;
                
        //    }
        //}

        private void btnBet_Click(object sender, EventArgs e)
        {
            p1.SetBet(1);
            FirstTwoRounds();
        }

        private void btnBet5D_Click(object sender, EventArgs e)
        {
            p1.SetBet(5);
            FirstTwoRounds();
        }

        private void btnBet25D_Click(object sender, EventArgs e)
        {
            p1.SetBet(25);
            FirstTwoRounds();
        }

        private void btnBet100D_Click(object sender, EventArgs e)
        {
            p1.SetBet(100);
            FirstTwoRounds();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            dealerdHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + de1.Hand.Last().Suit + "\\" + de1.Hand.Last().Rank + ".jpg");
            playerHandPictures.Last().Image.RotateFlip(RotateFlipType.Rotate180FlipXY);
            txtDPoints.Text = de1.Points.ToString();

            while (de1.Points<17)
            {                
                de1.Points=de1.Hit(d1);                
                dealerdHandPictures.Add(new PictureBox());
                dealerdHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + de1.Hand.Last().Suit + "\\" + de1.Hand.Last().Rank + ".jpg");
                dealerdHandPictures.Last().Size = new Size(74, 99);
                dealerdHandPictures.Last().Location = new Point(56 + d, 150);
                dealerdHandPictures.Last().Image.RotateFlip(RotateFlipType.Rotate180FlipXY);

                this.Controls.Add(dealerdHandPictures.Last());
                dealerdHandPictures.Last().BringToFront();

                txtDPoints.Text = de1.Points.ToString();
                d = d + 20;
            }

            if (Bust(de1) == true)
            {
                p1.Stack = p1.Stack + p1.Bet;
                NewRound();
            }
            else
                WhoWon();



        }

        public void NewRound()
        {
            btnHit.Enabled = false;
            btnBet1D.Enabled = true;
            btnBet5D.Enabled = true;
            btnBet25D.Enabled = true;
            btnBet100D.Enabled = true;
            p1.Hand.Clear();
            p1.Points = 0;
            txtP1Points.Text= p1.Points.ToString();
            p1.Bet = 0;
            txtPlayerBet.Text = p1.Bet.ToString();
            lblP1Stack.Text = p1.Stack.ToString();
            de1.Points = 0;
            txtDPoints.Text = de1.Points.ToString(); 
            foreach (PictureBox p in playerHandPictures)
                this.Controls.Remove(p);
            playerHandPictures.Clear();           
            i = 1;

            de1.Hand.Clear();
            de1.Points = 0;
            foreach (PictureBox p in dealerdHandPictures)
                this.Controls.Remove(p);
            dealerdHandPictures.Clear();
            d = 1;

            d1 = new Deck();
            d1.Shuffle();
        }

        public bool Bust(Player currentPlayer)
        {
            if (currentPlayer.Points > 21)
            {
                MessageBox.Show("Bust!");
                return true;
                NewRound();
            }
            else
                return false;

        }

        public void WhoWon()
        {
            if(p1.Points>de1.Points)
            {
                MessageBox.Show(p1.Name+" "+"ha vinto");
                p1.Stack = p1.Stack + p1.Bet * 2;
            }
            else if (de1.Points > p1.Points)
            {
                MessageBox.Show(p1.Name + " " + "ha perso");
            }
            else
            {
                MessageBox.Show("Pareggio");
                p1.Stack = p1.Stack + p1.Bet;
            }
            NewRound();
        }

        

        

    }
}
