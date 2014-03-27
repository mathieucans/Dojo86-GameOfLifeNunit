using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism
{
    public interface INeighboursCount
    {
        int GetCount(string[] p, int p_2, int p_3);
    }
}
