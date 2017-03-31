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

        private void MoveHorse(int[,] board, Position currentPosition, int doneMoves)
        {
            throw new NotImplementedException();
        }

        private void MarkMove(int[,] board, Position currentPosition, ref int doneMoves)
        {
            doneMoves++;
            board[currentPosition.row, currentPosition.col] = doneMoves;

        }

        private void UnMarkMove(int[,] board, Position currentPosition, ref int doneMoves)
        {
            board[currentPosition.row, currentPosition.col] = 0;
            doneMoves--;

        }
    }

    struct Position // una struct è un value type, la classe è una reference type
    {
        public int row;
        public int col;
    }
}
