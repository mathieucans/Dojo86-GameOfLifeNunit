using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameOfLifeReductionism.Test
{
    [TestFixture]
    public class NeighboursCountTest
    {
        [TestCase]
        public void Test1()
        {
            var neighboursCount = new NeighboursCount();

            var panel = new List<Cell>()
            {
            };

            Assert.AreEqual(0, neighboursCount.GetCount(panel, 0, 0));
        }

        [TestCase]
        public void Test2()
        {
            var neighboursCount = new NeighboursCount();

            var panel = new List<Cell>()
            {
                new Cell(1,1)
            };

            Assert.AreEqual(1, neighboursCount.GetCount(panel, 0, 0));
        }

        [TestCase]
        public void Test3()
        {
            var neighboursCount = new NeighboursCount();

            var panel = new List<Cell>()
            {
                new Cell(1,1),
                new Cell(0,1)
            };

            Assert.AreEqual(2, neighboursCount.GetCount(panel, 0, 0));
        }

        [TestCase]
        public void Test4()
        {
            var neighboursCount = new NeighboursCount();

            var panel = new List<Cell>()
            {
                new Cell(1,1),
                new Cell(2,2)
            };

            Assert.AreEqual(1, neighboursCount.GetCount(panel, 0, 1));
        }

        [TestCase]
        public void Test5()
        {
            var neighboursCount = new NeighboursCount();

            var panel = new List<Cell>()
            {
                new Cell(1,1),
                new Cell(0,1)
            };

            Assert.AreEqual(1, neighboursCount.GetCount(panel, 1, 1));
        }
        
    }
}
