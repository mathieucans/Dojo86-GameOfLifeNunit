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
        private IPanelConverter panelConverter;

        public GameOfLife(string[] panel, INeighboursCount neighboursCount, ICellStateSolver cellStateSolver, IPanelConverter panelConverter)
        {
            this.panel = panel;
            this.neighboursCount = neighboursCount;
            this.cellStateSolver = cellStateSolver;
            this.panelConverter = panelConverter;
        }

        public string[] Next()
        {
            var result = new List<string>();
            var list = panelConverter.Convert(panel);
            
           /* while(parcourreur.NextPos())
            {
                var neighbours = neighboursCount.GetCount(list, pos.row, pos.col);
                if (cellStateSolver.GetNextState(neighbours))
                {
                    newList.Add(new Cell(pos));
                }
            }*/

            for (int row = 0; row < 4; row++)
            {
                var temp = "";
                for (int col = 0; col < 4; col++)
                {
                    var neighbours = neighboursCount.GetCount(list, row, col);
                    temp += cellStateSolver.GetNextState(panel[row].ElementAt(col), neighbours);                    
                }
                result.Add(temp);
            }

            return result.ToArray();
        }
    }
}
