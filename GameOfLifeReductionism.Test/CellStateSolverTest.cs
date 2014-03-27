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
        public void Test1()
        {
            var cellSolver = new CellStateSolver();

            var res = cellSolver.GetNextState(1);

            Assert.AreEqual('-', res);
        }

        [TestCase]
        public void Test2()
        {
            var cellSolver = new CellStateSolver();

            var res = cellSolver.GetNextState(0);

            Assert.AreEqual('-', res);
        }

        [TestCase]
        public void Test3()
        {
            var cellSolver = new CellStateSolver();

            var res = cellSolver.GetNextState(2);

            Assert.AreEqual('X', res);
        }

        [TestCase]
        public void Test4()
        {
            var cellSolver = new CellStateSolver();

            var res = cellSolver.GetNextState(3);

            Assert.AreEqual('X', res);
        }


    }
}
