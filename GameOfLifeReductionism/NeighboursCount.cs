using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism
{
    public class NeighboursCount : INeighboursCount
    {
        public int GetCount( List<Cell> list, int x, int y)
        {
            int count = 0;
            foreach (var cell in list)
            {
                var distanceX = Math.Abs(cell.X - x);
                var distanceY = Math.Abs(cell.Y - y);
                if (distanceX <= 1 && distanceY <=1 && (distanceX == 1 | distanceY == 1))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
