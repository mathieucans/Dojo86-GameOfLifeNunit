using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism
{
    public class CellStateSolver : ICellStateSolver
    {
        public char GetNextState(int p)
        {
            return (p < 2) ? '-' : 'X';
        }
    }
}
