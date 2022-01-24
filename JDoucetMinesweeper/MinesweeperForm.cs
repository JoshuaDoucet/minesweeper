//this the the main windows form that the minesweeper game runs in

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JDoucetMinesweeper
{
   public partial class MinesweeperForm : Form
   {
      //Game board vars and objects
      const int ROWS = 10;
      const int COLS = 10;
      const int NUM_MINES = 10;

      //Game board
      Cell[,] cells = new Cell[ROWS, COLS];

      //game timer vars
      bool hasClockStarted = false;
      Timer gameTimer;
      int gameTime = 0;

      //init game stats
      GameStats stats = new GameStats();

      //Board locations of mines
      List<Coordinate> mineLocations;
      //Board locations of flagged mines
      List<Coordinate> flagLocations = new List<Coordinate>();

      public MinesweeperForm()
      {
         InitializeComponent();
         InitializeGame();
      }

      public void InitializeGame()
      {
         //Setup timer
         InitTimer();

         //Get random mine locations
         mineLocations = GetMineLocations(NUM_MINES, ROWS, COLS);

         //Initialize board objects
         InitBoard();

         //Mark mines on the apropriate panels
         MarkMinesOnBoard();
      }

      //Set up the game timer, tick once per second
      private void InitTimer()
      {
         gameTimer = new Timer();
         gameTimer.Interval = 1000;
         gameTimer.Tick += new EventHandler(UpdateGameClock);
      }

      //Create the gameboard
      private void InitBoard()
      {
         for (int i = 0; i < ROWS; i++)
            for (int j = 0; j < COLS; j++)
            {
               Cell cell = new Cell(i, j);
               cell.Button.MouseUp += Button_OnClick_Handler;
               cells[i, j] = cell;
               Controls.Add(cell.Panel);
            }
         //add some padding to the bottom of the board to account for the status strip
         Label padLabel = new Label();
         padLabel.Location = new Point(0, 30 + ROWS * Cell.BUT_AND_PAN_SIZE);
         Controls.Add(padLabel);
      }

      //Get random mine locations for a game of minesweeper
      private List<Coordinate> GetMineLocations(int numMines, int rows, int cols)
      {
         //Get random mine locations
         Random rand = new Random();
         //Return object
         List<Coordinate> mineLocs = new List<Coordinate>();
         //Num mines added to return list
         int minesSet = 0;
         //Used to add mines to return list
         int randRow, randCol;
         Coordinate tempCoord;
         //Used to determine if a mine is in a list
         bool mineFound;

         //Continue until all mine locations are found
         while (minesSet < numMines)
         {
            //Get a new random mine location
            randRow = rand.Next(0, rows);
            randCol = rand.Next(0, cols);
            tempCoord = new Coordinate(randRow, randCol);

            //Determine if the random location is already a mine
            mineFound = false;
            foreach (Coordinate mine in mineLocs)
            {
               if (mine.IsEqual(tempCoord))
                  mineFound = true;
            }

            //Add mine to return list if the location does not already exist in the list
            if (mineFound == false)
            {
               mineLocs.Add(tempCoord);
               minesSet++;
            }
         }
         return mineLocs;
      }

      //Updates all the panel labels that identify whether the cell
      //in the gameboard is a mine or how many mines that cell is touching if that cell is not a mine
      public void MarkMinesOnBoard()
      {
         //for each cell in the gameboard
         for (int row = 0; row < ROWS; row++)
         {
            for (int col = 0; col < COLS; col++)
            {
               //Create an ordered pair coord object for the cell
               Coordinate panLocation = new Coordinate(col, row);
               //Check if the cell location is the location of a mine
               bool atMineLocation = false;
               foreach (Coordinate mine in mineLocations)
               {
                  if (panLocation.IsEqual(mine))
                  {
                     atMineLocation = true;
                     break;
                  }
               }

               //If panel is a mine
               if (atMineLocation)
               {
                  cells[row, col].Label.Text = $"M";
               }
               //Panel is not a mine, find number of adjacent mines
               else
               {
                  //panels[row, col].BackColor = Color.Green;

                  //check how many mines are near a cell (the 8 surrounding cells) 
                  int minesNearby = 0;
                  foreach(Coordinate mine in mineLocations)
                  {
                     if ((mine.X == col - 1 && mine.Y == row) ||
                        (mine.X == col + 1 && mine.Y == row) ||
                        (mine.X == col && mine.Y == row - 1) ||
                        (mine.X == col && mine.Y == row + 1) ||
                        (mine.X == col - 1 && mine.Y == row - 1) ||
                        (mine.X == col + 1 && mine.Y == row + 1) ||
                        (mine.X == col - 1 && mine.Y == row + 1) ||
                        (mine.X == col + 1 && mine.Y == row - 1))
                        minesNearby++;
                  }
                  //dont add a text label for cells not near mines
                  if(minesNearby != 0)
                     cells[row,col].Label.Text = $"{minesNearby}";
               }
            }
         }
      }

      //Determine if a button is in the same location as a mine.
      //Button name must stores the location of the button on the baord.
      //EX: button name must be in format "button,row,col" where row and cal are the
      //    index of the button on the gameboard
      private bool ButtonIsMine(Coordinate buttonLoc)
      {
         bool buttonIsMine = false;
         foreach (Coordinate mineLoc in mineLocations)
         {
            if (mineLoc.IsEqual(buttonLoc))
            {
               buttonIsMine = true;
            }
         }
         return buttonIsMine;
      }

      //Handle mine logic when a button is left or right clicked
      //Flag mines, end game when needed (win or loss)
      public void Button_OnClick_Handler(object sender, EventArgs e)
      {
         //if this is the first button to be clicked start the game timer
         if (!hasClockStarted)
         {
            hasClockStarted = true;
            gameTimer.Start();
         }

         Button button = (Button)sender;
         string buttonName = button.Name;
         string[] nameParts = buttonName.Split(',');
         int row = Convert.ToInt32(nameParts[1]);
         int col = Convert.ToInt32(nameParts[2]);
         Coordinate buttonLoc = new Coordinate(col, row);

         //Check if button uncovers a mine
         bool isMine = ButtonIsMine(buttonLoc);

         MouseEventArgs me = (MouseEventArgs)e;
         //If right click
         if (me.Button == MouseButtons.Right)
         {
            //Add flag location to list of flagged mine locations
            if (!HasBeenFlagged(buttonLoc))
            {
               ((Button)sender).BackColor = Color.Red;
               flagLocations.Add(buttonLoc);
            }
            //Remove flag location from list of flagged locations
            else
            {
               ((Button)sender).BackColor = Cell.BUTTON_COLOR;
               RemoveFlag(buttonLoc);
            }
            //Check if all mines have been flagged
            if (IsGameWon())
               EndGame(true);
         }
         //else left click
         else
         {
            //Make the button disable and disapear
            ((Button)sender).Visible = false;
            ((Button)sender).Enabled = false;
            //If button is flagged and then left clicked, remove from flagged list
            if(((Button)sender).BackColor == Color.Red)
            {
               RemoveFlag(buttonLoc);
               //Check if all mines have been flagged
               if (IsGameWon())
                  EndGame(true);
            }
            if (isMine)
               //If button uncovers mine, end game
               EndGame(false);
         }
      }

      //Check if all mines have been flagged
      //if all mines flagged, return true
      private bool IsGameWon()
      {
         //lists must be same size
         if (mineLocations.Count != flagLocations.Count)
            return false;

         //all flags must be a mine location
         foreach(Coordinate mine in mineLocations)
         {
            bool mineIsFlagged = false;
            foreach(Coordinate flag in flagLocations)
            {
               if (mine.IsEqual(flag))
               {
                  mineIsFlagged = true;
               }
            }
            if (!mineIsFlagged)
               return false;
         }
         return true;
      }

      //If button loc is in flagLocations then remove the location from the list
      private void RemoveFlag(Coordinate buttonLoc)
      {
         Coordinate removeCoordinate = null;
         foreach(Coordinate flag in flagLocations)
         {
            if (flag.IsEqual(buttonLoc))
               removeCoordinate = flag;
         }
         flagLocations.Remove(removeCoordinate);
      }

      //Determine if the buttonLoc parameter has been flagged already
      private bool HasBeenFlagged(Coordinate buttonLoc)
      {
         bool buttonIsFlagged = false;
         foreach (Coordinate flagLoc in flagLocations)
         {
            if (flagLoc.IsEqual(buttonLoc))
            {
               buttonIsFlagged = true;
            }
         }
         return buttonIsFlagged;
      }

      //Update the on screen game timer in the status strip
      public void UpdateGameClock(Object sender, EventArgs e)
      {
         toolStripStatusLabel1.Text = $"Current game time: {++gameTime}";
      }

      //Game end event has been triggered. Display all mines and disable buttons. Prompt user
      //to see if they want to play another game.
      private void EndGame(bool hasWon)
      {
         gameTimer.Stop();
         
         //update stats file
         stats.WriteGameFile(hasWon, gameTime);
         
         //Display all mines and disable all buttons
         foreach (Cell cell in cells)
         {
            Button button = cell.Button;
            string buttonName = button.Name;
            string[] nameParts = buttonName.Split(',');
            int row = Convert.ToInt32(nameParts[1]);
            int col = Convert.ToInt32(nameParts[2]);
            Coordinate buttonLoc = new Coordinate(col, row);

            bool isMine = ButtonIsMine(buttonLoc);
            if (isMine)
            {
               button.Visible = false;
            }
            button.Enabled = false;
         }

         if (hasWon)
         {
            //Prompt user to see if they want to start a new game
            DialogResult answer = MessageBox.Show("YOU WIN!.\nStart a new game?", "All mines found!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
               Application.Restart();
            else
               Application.Exit();
         }
         else
         {
            //Prompt user to see if they want to start a new game
            DialogResult answer = MessageBox.Show("GAME OVER.\nStart a new game?", "Boom!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
               Application.Restart();
            else
               Application.Exit();
         }
      }

      //Below are the event handlers for clicks on options in the menu strip

      private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         MessageBox.Show("This implementation of Minesweeper was built and completed on" +
            " April 10 2020 by Joshua Doucet" +
            " for the course CS 3020 C#/.Net Programming at UCCS", "About",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      private void instructionsToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         InstructionsForm insForm = new InstructionsForm();
         insForm.Show();
      }

      private void showLifetimeStatsToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         MessageBox.Show(stats.ToString(), "Lifetime Game Stats",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      private void resetStatsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         //Prompt user to see if they want to start a new game
         DialogResult answer = MessageBox.Show("Are you sure you want to reset ALL game stats?", "Confirm",
             MessageBoxButtons.YesNo, MessageBoxIcon.Information);
         if (answer == DialogResult.Yes)
            stats.ResetStats();
      }

      //Restart game when "Restart Game" is sleceted in the menu bar
      private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Application.Restart();
      }

      //Exit the game when "Exit" is selected in the menu bar
      private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}
