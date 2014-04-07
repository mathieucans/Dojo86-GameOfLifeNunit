using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameOfLifeReductionism.IntegrationTest
{
    [TestFixture]
    [Ignore]
    public class US3
    {
        private GameOfLife Create(string[] init)
        {
            var game = new GameOfLife(init, new NeighboursCount(), new CellStateSolver(), new PanelConverter());
            return game;
        }

        [TestCase]
        public void Exemple1()
        {
            var init = new string[] {
                "-X--",
                "-XX-",
                "----",
                "----",
            };
            var game = Create(init);

            var expected = new string[] {
                "-X--",
                "-XX-",
                "----",
                "----",
            };
            CollectionAssert.AreEqual(expected, game.Next());
        }
    }
}
