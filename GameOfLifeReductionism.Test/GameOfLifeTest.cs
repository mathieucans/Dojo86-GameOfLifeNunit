using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameOfLifeReductionism.Test
{
    [TestFixture]
    public class GameOfLifeTest
    {
        [TestCase]
        public void FailedTest()
        {
            Assert.Fail();
        }
    }
}
