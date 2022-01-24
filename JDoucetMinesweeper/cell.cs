//This is a custom windows form that describes a cell in a minesweeper game.
//The cell has a panel, label, and button

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDoucetMinesweeper
{
   public partial class Cell : UserControl
   {
      public const int BUT_AND_PAN_SIZE = 35; //width and height of buttons and panels
      public static Color BUTTON_COLOR = Color.FromArgb(230, 242, 255);
      Button button = new Button();
      Panel panel = new Panel();
      Label label = new Label();

      public Button Button { get => button; set => button = value; }
      public Panel Panel { get => panel; set => panel = value; }
      public Label Label { get => label; set => label = value; }

      public Cell(int row, int col)
      {
         Button = MakeAButton(row, col);
         Label = MakeALabel();
         Panel = MakeAPanel(row, col);
         Panel.Controls.Add(Button);
         Panel.Controls.Add(Label);
         Controls.Add(Panel);
      }

      //Creates a square panel for a cell in the gameboard grid
      public Panel MakeAPanel(int row, int col)
      {
         Panel aPanel = new Panel();
         aPanel.Size = new Size(BUT_AND_PAN_SIZE, BUT_AND_PAN_SIZE);
         aPanel.BorderStyle = BorderStyle.FixedSingle;
         aPanel.Location = new Point(col * BUT_AND_PAN_SIZE, 30 + row * BUT_AND_PAN_SIZE);
         return aPanel;
      }

      //Creates a label that will identify values in the gameboard
      public Label MakeALabel()
      {
         Label aLabel = new Label();
         aLabel.Size = new Size(BUT_AND_PAN_SIZE, BUT_AND_PAN_SIZE);
         aLabel.Location = new Point(BUT_AND_PAN_SIZE / 2 - 6, BUT_AND_PAN_SIZE / 2 - 5);
         return aLabel;
      }

      //Creates a square button for a cell in the gameboard grid
      public Button MakeAButton(int row, int col)
      {
         Button aButton = new Button();
         aButton.BackColor = Cell.BUTTON_COLOR;
         aButton.Size = new Size(BUT_AND_PAN_SIZE, BUT_AND_PAN_SIZE);
         aButton.Name = $"button,{row},{col}";
         aButton.TabStop = false;
         return aButton;
      }

   }
}
