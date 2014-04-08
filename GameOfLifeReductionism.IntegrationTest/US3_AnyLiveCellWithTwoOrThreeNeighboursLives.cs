using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameOfLifeReductionism.IntegrationTest
{
    [TestFixture]
    public class US3_AnyLiveCellWithTwoOrThreeNeighboursLives
    {
        [TestCase]
        public void Exemple1()
        {
            var init = new string[] {
                "-X--",
                "-XX-",
                "----",
                "----",
            };
            var game = GameOfLifeFactory.Create(init);

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
