using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism
{
    public interface IPanelConverter
    {
        List<Cell> Convert(string[] panel);
    }
}
