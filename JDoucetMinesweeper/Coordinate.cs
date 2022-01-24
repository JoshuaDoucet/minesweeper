//This class describes a 2D grid coordinate position

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDoucetMinesweeper
{
   class Coordinate
   {
      int x;
      int y;

      public int X { get => x; set => x = value; }
      public int Y { get => y; set => y = value; }

      public Coordinate(int x, int y)
      {
         X = x;
         Y = y;
      }

      public bool IsEqual(Coordinate c2)
      {
         if (this.X == c2.X && this.Y == c2.Y)
            return true;
         else
            return false;
      }
   }
}
