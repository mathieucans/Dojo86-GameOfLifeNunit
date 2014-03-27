using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GameOfLifeReductionism;

namespace GameOfLifeReductionism.IntegrationTest
{
    [TestFixture]
    class US1_AnyLiveCellWithFewerThanTwoLiveNeighboursDies
    {
        private GameOfLife Create(string[] init)
        {
            var game = new GameOfLife(init);
            return game;
        }

        [TestCase]
        public void Exemple1()
        {
            var init = new string[] {
                "----",
                "-X--",
                "----",
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

        [TestCase]
        public void Exemple2()
        {
            var init = new string[] {
                "----",
                "-X--",
                "--X-",
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
