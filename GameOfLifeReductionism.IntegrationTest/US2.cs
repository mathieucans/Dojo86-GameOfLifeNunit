using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameOfLifeReductionism.IntegrationTest
{
    [TestFixture]
    public class US2
    {
        private GameOfLife Create(string[] init)
        {
            var game = new GameOfLife(init, new NeighboursCount(), new CellStateSolver());
            return game;
        }

        [TestCase]
        public void Exemple1()
        {
            var init = new string[] {
                "X-X-",
                "-X--",
                "X-X-",
                "----",
            };
            var game = Create(init);

            var expected = new string[] {
                "----",
                "----",
                "----",
                "----",
            };
            CollectionAssert.AreEqual(expected, game.Next());
        }
    }
}
