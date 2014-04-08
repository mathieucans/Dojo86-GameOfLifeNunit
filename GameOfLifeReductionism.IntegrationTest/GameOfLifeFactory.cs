using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism.IntegrationTest
{
    static class GameOfLifeFactory
    {
        public static GameOfLife Create(string[] init)
        {
            return new GameOfLife(init, new NeighboursCount(), new CellStateSolver(), new PanelConverter());
        }
    }
}
