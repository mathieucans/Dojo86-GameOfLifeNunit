using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeReductionism
{
    public class GameOfLife
    {
        private string[] panel;

        public GameOfLife(string[] panel)
        {
            this.panel = panel;
        }

        public string[] Next()
        {
            return this.panel;
        }
    }
}
