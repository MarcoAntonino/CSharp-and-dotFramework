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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    int BoardSize;
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

      int[,] Board = new int[BoardSize, BoardSize];

      Position InitialPosition;
      InitialPosition.row = 0;
      InitialPosition.col = 0;

      int DoneMoves = 0;

      Position CurrentPosition = InitialPosition;
      MarkMove(Board, CurrentPosition, ref DoneMoves);

      MoveHorse(Board, CurrentPosition, DoneMoves);
    }

    private void MoveHorse(int[,] Board, Position CurrentPosition, int DoneMoves)
    {
      throw new NotImplementedException();
    }

    private void MarkMove(int[,] Board, Position CurrentPosition, ref int DoneMoves)
    {
      DoneMoves++;
      Board[CurrentPosition.row, CurrentPosition.col] = DoneMoves;
    }

    private void UnmarkMove(int[,] Board, Position CurrentPosition, ref int DoneMoves)
    {
      Board[CurrentPosition.row, CurrentPosition.col] = 0;
      DoneMoves--;
    }


  }

  struct Position
  {
    public int row;
    public int col;
  }


}
