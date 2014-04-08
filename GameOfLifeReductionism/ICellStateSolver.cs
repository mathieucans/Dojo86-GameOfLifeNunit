using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism
{
    public interface ICellStateSolver
    {
        char GetNextState(char originalSate, int neigbourscount);
    }
}
