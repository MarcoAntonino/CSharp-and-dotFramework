using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourDelCavaliere
{
    public partial class TourDelCavaliere : Form
    {
        public TourDelCavaliere()
        {
            InitializeComponent();
        }

        private void TourDelCavaliere_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int BoardSize; //il valore della scacchiera
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                BoardSize = int.Parse(txtSize.Text);
            }
            catch
            {
                BoardSize = 8;
                txtSize.Text = BoardSize.ToString();
            }

            int[,] Board = new int[BoardSize, BoardSize]; //dichiarazione di array = istanziazione di array
            /*
             * Di default prende 0 come valore, quindi non abbiamo bisogno di inizializzarlo
             */

            Position InitialPosition; //non avendo dichiarato un modificatore di accesso, di defaultè privata
            InitialPosition.row = 0;
            InitialPosition.col = 0;
            /*
             * Altra differenza con le classi, non ho dovuto scrivere new
             */

            int DoneMoves = 0; //quando arriviamo a 64 siamo felici

            Position CurrentPosition = InitialPosition;
            MarkMove(Board, CurrentPosition, ref DoneMoves); //ref è la parola chiave per un puntatore, stiamo passando per reference

            MoveHorse(Board, CurrentPosition, DoneMoves);//in questo caso la passo in value perchè volgio essere sicuro che la mark move cambia la forma
            //bisogna dare a ogni metodo il suo territorio di intervento
        }

        int[,] Offset = new int[8, 2] { { 2, 1}, { 1, 2},
                                            {-1, 2}, {-2, 1},
                                            {-2,-1}, {-1,-2},
                                            { 1,-2}, { 2,-1} };

        private bool MoveHorse(int[,] board, Position currentPosition, int doneMoves)
        {
            if (doneMoves == BoardSize * BoardSize)
                return true;
            
            for (int i=0; i<8;i++)
            {
                Position NextPosition = currentPosition;
                NextPosition.col += Offset[i, 0];
                NextPosition.row += Offset[i, 1];
                if (IsValid(board, NextPosition))
                {
                    MarkMove(board, NextPosition, ref doneMoves);
                    if (MoveHorse(board, NextPosition, doneMoves))
                        return true;
                    //nelle procedure ricorsive, il vero aspetto critivo è quando terminare la ricorsione
                    UnMarkMove(board, NextPosition, ref doneMoves);
                }
            }

            return false;
        }

        private bool IsValid (int [,] board, Position p)
        {
            if (p.row < 0 || p.row >= BoardSize || p.col < 0 || p.col >= BoardSize)
                return false;
            if (board[p.row, p.col] != 0)
                return false;
            return true;
        }

        private void MarkMove(int[,] board, Position currentPosition, ref int doneMoves)
        {
            doneMoves++;
            board[currentPosition.row, currentPosition.col] = doneMoves;
            ShowBoard(board);

        }

        private void UnMarkMove(int[,] board, Position currentPosition, ref int doneMoves)
        {
            board[currentPosition.row, currentPosition.col] = 0;
            doneMoves--;

        }

        private void ShowBoard(int [,] Board)
        {
            for (int r=0; r<BoardSize; r++)
            {
                for (int c=0; c<BoardSize; c++)
                {
                    string TextBoxName = "txt" + r.ToString() + "_" + c.ToString();
                    TextBox t = (TextBox)this.Controls[TextBoxName];
                    if (t==null)
                    {                    
                        t = new TextBox();
                        t.Name = TextBoxName;
                        t.Size = new Size(26, 22);
                        t.Location = new Point(10 + c * 26, 50 + r * 22);
                        this.Controls.Add(t);
                    }
                    if (Board[r,c]==0)
                    {
                        t.Text = "";
                        t.BackColor = Color.White;
                    }
                    else
                    {
                        t.Text = String.Format("{0:D2}", Board[r,c]);
                        t.BackColor = Color.LightGreen;
                    }
                }
            }

            Application.DoEvents();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    struct Position // una struct è un value type, la classe è una reference type
    {
        public int row;
        public int col;
    }
}
