//Programmer: Joshua Doucet
//Date of code completion: April 10 2020
//Project: Minesweeper
//Created for course CS 3020

//Description: This is an implementation of the classic Windows game called Minesweeper
// where a user must find hidden mines on a gameboard grid

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDoucetMinesweeper
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MinesweeperForm());
      }
   }
}
