using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameOfLifeReductionism.Test
{
    [TestFixture]
    public class PanelConverterTest
    {
        [TestCase]
        public void NoLiveCellReturnEmptyList()
        {
            var converter = new PanelConverter();

            var result = converter.Convert(new [] {"....", "....", "....", "...."});

            Assert.AreEqual(0, result.Count);
        }

        [TestCase]
        public void OneLiveCellReturnOneCell()
        {
            var converter = new PanelConverter();

            var result = converter.Convert(new[] { ".X..", "....", "....", "...." });

            CollectionAssert.AreEqual(new [] {new Cell(1,0)}, result.ToArray());
        }
    }
}
