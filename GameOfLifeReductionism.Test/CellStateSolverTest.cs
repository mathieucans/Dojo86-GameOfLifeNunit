using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameOfLifeReductionism.Test
{
    [TestFixture]
    public class CellStateSolverTest
    {
        [TestCase]
        public void ALiveCellWithOnNeighboursDies()
        {
            var cellSolver = new CellStateSolver();

            var res = cellSolver.GetNextState('X', 1);

            Assert.AreEqual('-', res);
        }

        [TestCase]
        public void ALiveCellWithNoNeigboursDies()
        {
            var cellSolver = new CellStateSolver();

            var res = cellSolver.GetNextState('X', 0);

            Assert.AreEqual('-', res);
        }

        [TestCase]
        public void ALiveCellWithTwoNeigboursLives()
        {
            var cellSolver = new CellStateSolver();

            var res = cellSolver.GetNextState('X', 2);

            Assert.AreEqual('X', res);
        }

        [TestCase]
        public void ALiveCellWithThreeNeigboursLives()
        {
            var cellSolver = new CellStateSolver();

            var res = cellSolver.GetNextState('X', 3);

            Assert.AreEqual('X', res);
        }

        [TestCase]
        public void ALiveCellWithFourNeigboursDies()
        {
            var cellSolver = new CellStateSolver();

            var res = cellSolver.GetNextState('X', 4);

            Assert.AreEqual('-', res);
        }


    }
}
