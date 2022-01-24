//This class describes the games stats from multiple games of minesweeper
//The stats are stored in a nonvolatile text file and are loaded and updated using 
//methods in this class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JDoucetMinesweeper
{
   class GameStats
   {
      long wins;
      long losses;
      long totalTime;

      public long Wins { get => wins; set => wins = value; }
      public long Losses { get => losses; set => losses = value; }
      public long TotalTime { get => totalTime; set => totalTime = value; }

      public GameStats()
      {
         ReadGameFile();
      }

      private void ReadGameFile()
      {
         try
         {
            //Reads stats from nonvolatile storage
            StreamReader sr = new StreamReader("GameStats.txt");
            Wins = Convert.ToInt32(sr.ReadLine());
            Losses = Convert.ToInt32(sr.ReadLine());
            TotalTime = Convert.ToInt32(sr.ReadLine());
            sr.Close();
         }
         catch (Exception e)
         {
            Console.WriteLine(e.Message);
         }
      }

      //Given the end game results, (win/loss) and the game time, update the game stats file
      public void WriteGameFile(bool gameWin, long gameTime)
      {
         StreamWriter sw = new StreamWriter("GameStats.txt");
         if (gameWin)
            Wins = ++Wins;
         else
            Losses = ++Losses;

         TotalTime += gameTime;

         sw.WriteLine(Wins);
         sw.WriteLine(Losses);
         sw.WriteLine(TotalTime);
         sw.Close();
      }

      private long GetAvgTime()
      {
         try
         {
            return Convert.ToInt32(totalTime / (Wins + Losses));
         }
         catch (DivideByZeroException d)
         {
            return 0;
         }
      }

      public void ResetStats()
      {
         StreamWriter sw = new StreamWriter("GameStats.txt");
         Wins = 0;
         Losses = 0;
         TotalTime = 0;
         sw.WriteLine(0);
         sw.WriteLine(0);
         sw.WriteLine(0);
         sw.Close();
      }

      public override string ToString()
      {
         if(losses == 0)
         {
            return $"Wins: {Wins}" +
                $"\nLosses: {Losses}" +
                $"\nWin/Loss Ratio: {String.Format("{0:0.00}", Wins)}" +
                $"\nTotal time: {TotalTime}" +
                $"\nAverage game length: {GetAvgTime()}";
         }
         else
         {
            return $"Wins: {Wins}" +
               $"\nLosses: {Losses}" +
               $"\nWin/Loss Ratio: {String.Format("{0:0.00}", Wins * 1.0 / Losses)}" +
               $"\nTotal time: {TotalTime}" +
               $"\nAverage game length: {GetAvgTime()}";
         }

      }
   }
}
