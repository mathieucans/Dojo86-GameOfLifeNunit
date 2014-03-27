using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism
{
    public class GameOfLife
    {
        private string[] panel;
        private INeighboursCount neighboursCount;
        private ICellStateSolver cellStateSolver;

        public GameOfLife(string[] panel, INeighboursCount neighboursCount, ICellStateSolver cellStateSolver)
        {
            this.panel = panel;
            this.neighboursCount = neighboursCount;
            this.cellStateSolver = cellStateSolver;
        }

        public string[] Next()
        {
            var result = new List<string>();
            for (int row = 0; row < 4; row++)
            {
                var temp = "";
                for (int col = 0; col < 4; col++)
                {
                    var neighbours = neighboursCount.GetCount(panel, row, col);
                    temp += cellStateSolver.GetNextState(neighbours);
                }
                result.Add(temp);
            }

            return result.ToArray();
        }
    }
}
