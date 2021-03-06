﻿using BlackJack.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BlackJack.CLI
{
    /// <summary>
    /// This form controls the program's logic
    /// </summary>
    public partial class Form1 : Form
    {


        
        public string machineImagePath = "D:\\Utenti\\Nuova cartella\\ITS\\CSharp-and-dotFramework\\TopicRecap2";
        int i = 1;
        int d = 1;


        private List<PictureBox> playerHandPictures = new List<PictureBox>();//to control the view of the player hand
        public List<PictureBox> dealerdHandPictures = new List<PictureBox>();//to control the view of the dealer hand
        Deck d1 = new Deck();
        HumanPlayer p1 = new HumanPlayer("Marco");
        Dealer de1 = new Dealer();

        Game gioco = new Game();
        string fileName = "gamesHistorical";

        /*
         * IMPORTANT: 
         * change the value of machineImagePath to match your actual project path
         */
        //public string machineImagePath = "C:\\Users\\NewMarco\\Documents\\ITS ICT\\CSharp-and-dotFramework\\TopicRecap2";

        //public string machineImagePath  = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TopicRecap2";

        string ciao = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TopicRecap2";

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

        /// <remark>
        /// After the player set's a bet, the game starts.
        /// This method simulates the ditribution of two cards each to the player and the dealer.
        /// It shows the points and the cards of the player but not the second card and its points of the dealer's hand (as written in BJ rules)
        /// </remark>
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

        /// <remark>
        /// After the first two turns the player can Hit or Stand.
        /// Every time this method is called, adds cards in the player's hand until his Points are >21. 
        /// If the Player points are >21, this method catches a custom exception and shows a message and calls the NewRound() method
        /// </remark>
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
                MessageBox.Show(this, "Player has Bust!");
                gioco.EndDate = DateTime.Now;
                DealerWins();
                NewRound();                

            }



        }

        /// <remark>
        /// Method that sets the Game object parameters for serialization
        /// </remark>
        public void DealerWins()
        {
            gioco.PlayerPoints = p1.Points;
            gioco.DealerPoints = de1.Points;
            gioco.WinnerName = "Dealer";
            SaveAsXmlFormat(gioco, fileName);


        }

        /// <remark>
        /// Method that sets the Game object parameters for serialization
        /// </remark>
        public void PlayerWins()
        {
            gioco.PlayerPoints = p1.Points;
            gioco.DealerPoints = de1.Points;
            gioco.WinnerName = p1.Name;
            SaveAsXmlFormat(gioco, fileName);
        }

        /// <remark>
        /// Method that sets the Game object parameters for serialization
        /// </remark>
        public void NoOneWins()
        {
            gioco.PlayerPoints = p1.Points;
            gioco.DealerPoints = de1.Points;
            gioco.WinnerName = "Draw";
            SaveAsXmlFormat(gioco, fileName);

        }

        /// <remark>
        /// In case the player picks an ace, this method show a popup window to manually allow the player to choose the value of the ace
        /// </remark>
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

        /// <remark>
        /// Pass a value of 1$ to the player bet property and starts the turn
        /// </remark>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBet_Click(object sender, EventArgs e)
        {
            gioco.StartDate = DateTime.Now;
            p1.SetBet(1);
            FirstTwoRounds();
        }

        /// <remark>
        /// Pass a value of 5$ to the player bet property and starts the turn
        /// </remark>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBet5D_Click(object sender, EventArgs e)
        {
            p1.SetBet(5);
            FirstTwoRounds();
        }

        /// <remark>
        /// Pass a value of 25$ to the player bet property and starts the turn
        /// </remark>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBet25D_Click(object sender, EventArgs e)
        {
            p1.SetBet(25);
            FirstTwoRounds();
        }

        /// <remark>
        /// Pass a value of 100$ to the player bet property and starts the turn
        /// </remark>
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

        /// <remark>
        /// This method is called when the player decides to stop extracting cards from the deck.
        /// Now it's the dealer turn.
        /// This method shows the second card in the dealer hand and updates his current point.
        /// Then the dealer extracts cards from the dack until his points are >16, then he stops.
        /// If the dealer's point are >21 this method catches a custom exception and shows a message.
        /// At the end, this method calls the WhoWon() method
        /// </remark>
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

        /// <remark>
        /// At the end of the dealer's turn, this method it's called to decide who won the game.
        /// The BJ rules for the victory are slightly differents from the teacher's requests, I've followed the online documentation.
        /// After the victory assignment, this method calls the NewRound() method
        /// </remark>
        public void WhoWon()
        {
            if(de1.IsBust)
            {
                if(p1.Points==21 && p1.Hand.Count==2)
                {
                    MessageBox.Show("21 vittoria, grande baldoria!");
                    p1.Stack = p1.Stack + p1.Bet + p1.Bet * 1.5;
                    PlayerWins();
                }
                else
                {
                    p1.Stack = p1.Stack + p1.Bet * 2;
                    PlayerWins();

                }
            }
            else
            {
                if (p1.Points == 21 && p1.Hand.Count == 2 && de1.Points!=21)
                {
                    MessageBox.Show("21 vittoria, grande baldoria!");
                    p1.Stack = p1.Stack + p1.Bet + p1.Bet * 1.5;
                    PlayerWins();

                }
                else if (p1.Points > de1.Points)
                {
                    MessageBox.Show("Il giocatore ha vinto");
                    p1.Stack = p1.Stack + p1.Bet * 2;
                    PlayerWins();

                }
                else if (p1.Points == de1.Points)
                {
                    p1.Stack = p1.Stack + p1.Bet;
                    MessageBox.Show("Pareggio");
                    NoOneWins();
                }
                else
                {
                    MessageBox.Show("Il giocatore ha perso");
                    DealerWins();
                }

            }
            NewRound();
        }


        /// <remark>
        /// This method it's called at the end of the game.
        /// It's reset all the game parameters
        /// </remark>
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

        /// <remark>
        /// Method that saves game results in a xml file
        /// </remark>
        /// <param name="objGraph"></param>
        /// <param name="fileName"></param>
        static void SaveAsXmlFormat(object objGraph, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Game));

            using (Stream fStream = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }

        }







    }
}
