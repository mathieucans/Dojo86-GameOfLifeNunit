using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameOfLifeReductionism.IntegrationTest;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new US1_AnyLiveCellWithFewerThanTwoLiveNeighboursDies();

            t1.Exemple2();
        }
    }
}
