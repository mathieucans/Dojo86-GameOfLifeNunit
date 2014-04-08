using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism
{
    public class Cell
    {
        public int X {get; private set;}
        public int Y { get; private set; }

        public Cell(int x, int y)
        {
            // TODO: Complete member initialization
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj)
        {
            var result = false;
            if (obj is Cell)
            {
                var cell = (Cell)obj;
                result = this.X == cell.X && this.Y == cell.Y;
            }
            return result;
         
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }
    }
}
