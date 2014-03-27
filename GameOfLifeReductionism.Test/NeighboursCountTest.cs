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

            var panel = new string[]{
                "----",
                "----",
                "----",
                "----",
            };

            Assert.AreEqual(0, neighboursCount.GetCount(panel, 0, 0));
        }
    }
}
