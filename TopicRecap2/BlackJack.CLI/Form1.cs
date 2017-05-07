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
    /// <summary>
    /// This form controls the program's logic
    /// </summary>
    public partial class Form1 : Form
    {
        private List<PictureBox> playerHandPictures = new List<PictureBox>();//to control the view of the player hand
        public List<PictureBox> dealerdHandPictures = new List<PictureBox>();//to control the view of the dealer hand

        /*
         * IMPORTANT: 
         * change the value of machineImagePath to match your actual project path
         */
        public string machineImagePath = "C:\\Users\\NewMarco\\Documents\\ITS ICT\\CSharp-and-dotFramework\\TopicRecap2";

        int i = 1; //offset value for the Player's hand view
        int d = 1; //offset value for the dealer's hand view

        Form popUp = new AceValueChoice();   


        public Form1()
        {
            InitializeComponent();            
            lblP1Name.Text = p1.Name;
            txtP1Points.Text = p1.Points.ToString();
            txtPlayerBet.Text = p1.Bet.ToString();
            lblP1Stack.Text = p1.Stack.ToString();
            btnHit.Enabled = false; // your first move cannot be hit
            btnStand.Enabled = false; // your first move cannot be stand


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        Deck d1 = new Deck();
        HumanPlayer p1 = new HumanPlayer("Marco");
        Dealer de1 = new Dealer();


        //just a test
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

        

        

        private void lblPlayer1_Click(object sender, EventArgs e)
        {
            
        }

                
        public void Hand()
        {
            
                        
        }

        /// <summary>
        /// After the player set's a bet, the game starts.
        /// This method simulates the ditribution of two cards each to the player and the dealer.
        /// It shows the points and the cards of the player but not the second card and its points of the dealer's hand (as written in BJ rules)
        /// </summary>
        public void FirstTwoRounds()
        {
            txtPlayerBet.Text = p1.Bet.ToString();
            lblP1Stack.Text = p1.Stack.ToString();

            //First turn
            d1.Shuffle();
            p1.Hit(d1);
            PlayerAceValue();
            playerHandPictures.Add(new PictureBox());
            playerHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + p1.Hand.Last().Suit + "\\" + p1.Hand.Last().Rank + ".jpg");
            playerHandPictures.Last().Size = new Size(74, 99);
            playerHandPictures.Last().Location = new Point(56 + i, 400);
            this.Controls.Add(playerHandPictures.Last());
            txtP1Points.Text = p1.Points.ToString();
            i = i + 20; //increments the offset value

            de1.Hit(d1);
            dealerdHandPictures.Add(new PictureBox());
            dealerdHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + de1.Hand.Last().Suit + "\\" + de1.Hand.Last().Rank + ".jpg");
            dealerdHandPictures.Last().Size = new Size(74, 99);
            dealerdHandPictures.Last().Location = new Point(56 + d, 150);
            this.Controls.Add(dealerdHandPictures.Last());
            txtDPoints.Text = de1.Points.ToString();
            d = d + 20;

            //Second turn
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

            //The player can't bet during a turn
            btnBet1D.Enabled = false;
            btnBet5D.Enabled = false;
            btnBet25D.Enabled = false;
            btnBet100D.Enabled = false;
            btnHit.Enabled = true;
            btnStand.Enabled = true;

        }

        /// <summary>
        /// After the first two turns the player can Hit or Stand.
        /// Every time this method is called, adds cards in the player's hand until his Points are >21. 
        /// If the Player points are >21, this method catches a custom exception and shows a message and calls the NewRound() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hit_Click(object sender, EventArgs e)
        {
            try
            {
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
            }
            catch (PlayerPointsOutOfRangeException ex)
            {

                playerHandPictures.Add(new PictureBox());
                playerHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + p1.Hand.Last().Suit + "\\" + p1.Hand.Last().Rank + ".jpg");
                playerHandPictures.Last().Size = new Size(74, 99);
                playerHandPictures.Last().Location = new Point(56 + i, 400);
                this.Controls.Add(playerHandPictures.Last());
                playerHandPictures.Last().BringToFront();
                txtP1Points.Text = p1.Points.ToString();
                MessageBox.Show("Player has Bust!");
                NewRound();

            }



        }

        /// <summary>
        /// In case the player picks an ace, this method show a popup window to manually allow the player to choose the value of the ace
        /// </summary>
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

        /// <summary>
        /// Pass a value of 1$ to the player bet property and starts the turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBet_Click(object sender, EventArgs e)
        {
            p1.SetBet(1);
            FirstTwoRounds();
        }

        /// <summary>
        /// Pass a value of 5$ to the player bet property and starts the turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBet5D_Click(object sender, EventArgs e)
        {
            p1.SetBet(5);
            FirstTwoRounds();
        }

        /// <summary>
        /// Pass a value of 25$ to the player bet property and starts the turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBet25D_Click(object sender, EventArgs e)
        {
            p1.SetBet(25);
            FirstTwoRounds();
        }

        /// <summary>
        /// Pass a value of 100$ to the player bet property and starts the turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method is called when the player decides to stop extracting cards from the deck.
        /// Now it's the dealer turn.
        /// This method shows the second card in the dealer hand and updates his current point.
        /// Then the dealer extracts cards from the dack until his points are >16, then he stops.
        /// If the dealer's point are >21 this method catches a custom exception and shows a message.
        /// At the end, this method calls the WhoWon() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStand_Click(object sender, EventArgs e)
        {
            dealerdHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + de1.Hand.Last().Suit + "\\" + de1.Hand.Last().Rank + ".jpg");
            playerHandPictures.Last().Image.RotateFlip(RotateFlipType.Rotate180FlipXY);
            txtDPoints.Text = de1.Points.ToString();

            try
            {
                while (de1.Points < 17)
                {
                    de1.Points = de1.Hit(d1);
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

            }
            catch (DealerPointsOutOfRangeException ex)
            {
                dealerdHandPictures.Add(new PictureBox());
                dealerdHandPictures.Last().Image = Image.FromFile(machineImagePath + "\\BlackJack.CLI\\Cards\\" + de1.Hand.Last().Suit + "\\" + de1.Hand.Last().Rank + ".jpg");
                dealerdHandPictures.Last().Size = new Size(74, 99);
                dealerdHandPictures.Last().Location = new Point(56 + d, 150);
                dealerdHandPictures.Last().Image.RotateFlip(RotateFlipType.Rotate180FlipXY);

                this.Controls.Add(dealerdHandPictures.Last());
                dealerdHandPictures.Last().BringToFront();

                txtDPoints.Text = de1.Points.ToString();
                d = d + 20;
                MessageBox.Show("Dealer has Bust!");
                WhoWon();
            }
            
            WhoWon();





        }

        /// <summary>
        /// At the end of the dealer's turn, this method it's called to decide who won the game.
        /// The BJ rules for the victory are slightly differents from the teacher's requests, I've followed the online documentation.
        /// After the victory assignment, this method calls the NewRound() method
        /// </summary>
        public void WhoWon()
        {
            if(de1.IsBust)
            {
                if(p1.Points==21 && p1.Hand.Count==2)
                {
                    MessageBox.Show("21 vittoria, grande baldoria!");
                    p1.Stack = p1.Stack + p1.Bet + p1.Bet * 1.5;
                }
                else
                {
                    p1.Stack = p1.Stack + p1.Bet * 2;
                }
            }
            else
            {
                if (p1.Points == 21 && p1.Hand.Count == 2 && de1.Points!=21)
                {
                    MessageBox.Show("21 vittoria, grande baldoria!");
                    p1.Stack = p1.Stack + p1.Bet + p1.Bet * 1.5;
                }
                else if (p1.Points > de1.Points)
                {
                    p1.Stack = p1.Stack + p1.Bet * 2;
                    MessageBox.Show("Il giocatore ha vinto");
                }
                else if (p1.Points == de1.Points)
                {
                    p1.Stack = p1.Stack + p1.Bet;
                    MessageBox.Show("Pareggio");

                }
                else
                    MessageBox.Show("Il giocatore ha perso");
                
            }
            NewRound();
        }


        /// <summary>
        /// This method it's called at the end of the game.
        /// It's reset all the game parameters
        /// </summary>
        public void NewRound()
        {
            btnHit.Enabled = false;
            btnBet1D.Enabled = true;
            btnBet5D.Enabled = true;
            btnBet25D.Enabled = true;
            btnBet100D.Enabled = true;
            p1.Hand.Clear();
            p1.Points = 0;
            txtP1Points.Text = p1.Points.ToString();
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







    }
}
