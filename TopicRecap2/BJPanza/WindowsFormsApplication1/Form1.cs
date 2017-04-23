using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public int PlayerScore { get; set; }
        public int PcScore { get; set; }
        public int PlayerMoney { get; set; }
        public byte Turn { get; set; }
        public int Position { get; set; }
        public int Hit { get; set; }  //serve solo a dare il nome alle label delle carte
        public int Bet { get; set; }

        const int numCards = 52;    //numero carte nel mazzo
        const double winHand = 2;   //1:1
        const double winBlack = 2.5;    //3:2

        public Deck deck { get; set; }
        public Card extractedCard { get; set; }

        List<Card> PlayerHand;
        List<Label> PlayerLabels;
        List<Card> PcHand;
        List<Label> PcLabels;

        public Form1()
        {
            InitializeComponent();

            PlayerMoney = 100;

            deck = new Deck(numCards);
        }

        public void initializeGame(int Hit)
        {
            PlayerHand = new List<Card>();
            PlayerLabels = new List<Label>();
            PcHand = new List<Card>();
            PcLabels = new List<Label>();

            if (Hit != 1)
            {
                //eliminare le carte estratte dal tavolo
            }

            Position = 0;
            PlayerScore = 0;
            PcScore = 0;
            Turn = 0;
            Bet = 0;
            Hit = 1;
            deck.shuffle(2*numCards);
            //inizio partita
            lblPcTurn.Hide();
            /*Hand(Turn);
            Hand(Turn);

            Turn = 1;
            Hand(Turn);*/

            lblPcPoint.Text = PcScore.ToString();
            lblPlayerPoints.Text = PlayerScore.ToString();
            lblPlayerMoney.Text = PlayerMoney.ToString();
            lblBetAmount.Text = Bet.ToString();

            /*if (PlayerScore == 21)
            {
                System.Threading.Thread.Sleep(500);
                Hand(Turn);
                if (PcScore != 21)
                {
                    MessageBox.Show("BLACKJACK! You win.");
                    PlayerMoney += (int)(Bet * winBlack);
                }
                else if (PcScore == 21)
                    {
                        MessageBox.Show("PUSH! Nothing done.");
                        PlayerMoney += Bet;
                    }
            }*/

            //Turn = 0;
        }

        public Label createLabel(Card Card, int size)
        {
            Label newLabel = new Label();
            newLabel.Name = "lbl" + Hit.ToString();
            int y;

            if (Card.Rank == Rank.Ace) newLabel.Text = "A";
            else if(Card.Rank == Rank.Jack)
                    newLabel.Text = "J";
                else if(Card.Rank == Rank.Queen)
                        newLabel.Text = "Q";
                    else if(Card.Rank == Rank.Queen)
                            newLabel.Text = "K";
                        else
                            newLabel.Text = Card.getPoints().ToString();

            if (Card.Suit == Suit.Hearts)
                newLabel.Image = Properties.Resources.hearts;
            else if(Card.Suit == Suit.Spades)
                newLabel.Image = Properties.Resources.spades;
                else if(Card.Suit == Suit.Clubs)
                    newLabel.Image = Properties.Resources.clubs;
                    else if (Card.Suit == Suit.Diamonds)
                        newLabel.Image = Properties.Resources.diamonds;
            //newLabel.Left = (size - 1) * 50;
            if (Turn == 0)
                y = 350;
            else
                y = 50;
            newLabel.Location = new Point((size)*50 + 10, y);
            newLabel.Size = new Size(50, 70);
            Hit++;
            return newLabel;
        }

        public void setBetAmount(int amount)
        {
            if (PlayerMoney - amount >= 0)
            {
                Bet = Bet + amount;
                PlayerMoney -= amount;
            }
            lblBetAmount.Text = Bet.ToString();
            lblPlayerMoney.Text = PlayerMoney.ToString();
        }

        public void changeTurn()
        {
            if (Turn == 0)
            {
                lblPcTurn.Show();
                lblPlayerTurn.Hide();
                Turn = 1;
            }
            else
            {
                lblPlayerTurn.Show();
                lblPcTurn.Hide();
                Turn = 0;
            }
        }

        public void controlPoints()
        {
            //if (Turn == 0)
            //{
            if (PlayerScore > 21)
            {
                MessageBox.Show("BUST! You lose this turn.");
                initializeGame(Hit);
            }
            //}
            else if (PlayerScore == 21)
                {
                    System.Threading.Thread.Sleep(500);
                    Hand();
                    if (PcScore != 21)
                    {
                        MessageBox.Show("BLACKJACK! You win.");
                        PlayerMoney += (int)(Bet * winBlack);
                    }
                    else if (PcScore == 21)
                        {
                            MessageBox.Show("PUSH! Nothing done.");
                            PlayerMoney += Bet;
                        }
                }
        }

        public void Hand()
        {
            if (Turn == 0)  //carta giocatore
            {
                extractedCard = deck.extract(Position);
                PlayerScore += extractedCard.getPoints();
                PlayerHand.Add(extractedCard);
                PlayerLabels.Add(createLabel(PlayerHand.Last(), PlayerLabels.Count));
                this.Controls.Add(PlayerLabels.Last());
                lblPlayerPoints.Text = PlayerScore.ToString();
                controlPoints();
            }
            else //carta pc
            {
                extractedCard = deck.extract(Position); 
                PcScore += extractedCard.getPoints();
                PcHand.Add(extractedCard);
                PcLabels.Add(createLabel(PcHand.Last(), PcLabels.Count));
                this.Controls.Add(PcLabels.Last());
                lblPcPoint.Text = PcScore.ToString();
                controlPoints();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeGame(Hit);
        }

        private void btnBet1_Click(object sender, EventArgs e)
        {
            setBetAmount(2);
        }

        private void btnBet5_Click(object sender, EventArgs e)
        {
            setBetAmount(10);
        }

        private void btnBet10_Click(object sender, EventArgs e)
        {
            setBetAmount(20);
        }

        private void btnBet50_Click(object sender, EventArgs e)
        {
            setBetAmount(50);
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            if (Bet > 0)
            {
                if (Hit == 1)
                {
                    Hand();
                    //System.Threading.Thread.Sleep(400);
                    Hand();

                    Turn = 1;
                    //System.Threading.Thread.Sleep(400);
                    Hand();

                    Turn = 0;
                }
                else
                {
                    Hand();
                }
            }
            else
            {
                MessageBox.Show("You first need to bet");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            changeTurn();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            if (Hit < 4)
            {
                if (Bet > 0)
                {
                    if (PlayerMoney - Bet >= 0)
                    {
                        PlayerMoney -= Bet;
                        Bet *= 2;
                        lblBetAmount.Text = Bet.ToString();
                        lblPlayerMoney.Text = PlayerMoney.ToString();
                        Hand();
                        changeTurn();
                    }
                }
                else
                {
                    MessageBox.Show("You first need to bet");
                }
            }
            else
            {
                MessageBox.Show("Your already had Hits");
            }
        }

        private void lblDeck_Click(object sender, EventArgs e)
        {

        }
    }
}
