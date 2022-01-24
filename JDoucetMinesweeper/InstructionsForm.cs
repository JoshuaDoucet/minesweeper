//This windows form is used to display instructions on how to play minesweeper

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDoucetMinesweeper
{
   public partial class InstructionsForm : Form
   {
      public InstructionsForm()
      {
         InitializeComponent();
         instructionsTextBox.Text = "Minesweeper is a Classic Windows game where a grid is displayed that has hidden mines underneath buttons. " +
            "The objective of the game is to identify the location of all the mines without accidently uncovering any of them." +
            "\n\nThis implementation of the game has 10 hidden mines on a 10 by 10 grid of squares. When a grid square is left clicked" +
            " by a mouse the button on the grid square will disappear which will either have a mine underneath depicted by an \"M\", or the number of" +
            " mines that are surrounding that grid square. This number includes mines that are one square diagonal from that position" +
            " as well. If no mines are in one of the 8 adjacent grid squares, then there will be no mine and no number in a grid square " +
            "once the grid button has been left clicked. \n\nRight mouse click a grid square to flag a square that is suspected to contain" +
            " a mine. The game is won when all the mines have been flagged. The game cannot be won if there are grid squares that are " +
            "flagged that do not have mines underneath them.\n\nThe game is lost if a gird square with a mine is left mouse clicked." +
            "\n\nGame play times are recorded in seconds";
      }
   }
}
