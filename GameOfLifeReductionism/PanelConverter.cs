using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism
{
    public class PanelConverter : IPanelConverter
    {
        public List<Cell> Convert(string[] panel)
        {
            var result = new List<Cell>();
            var lineIdx = 0;
            foreach (var line in panel)
            {
                var cellIdx = 0;
                foreach (var cell in line)
                {
                    if (cell == 'X')
                    {
                        result.Add(new Cell(cellIdx,lineIdx));
                    }
                    cellIdx++;
                }
                lineIdx++;

            }
            return result;
        }
    }
}
