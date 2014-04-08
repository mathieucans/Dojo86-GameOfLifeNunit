using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism
{
    public class CellStateSolver : ICellStateSolver
    {
        public char GetNextState(char originalSate, int neighboursCount)
        {
            if (originalSate == 'X')
            {
                return (neighboursCount < 2 || neighboursCount > 3) ? '-' : 'X';
            }
            else
            {
                return '-';
            }
        }
    }
}
