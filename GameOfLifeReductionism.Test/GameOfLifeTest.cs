using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FakeItEasy;
using GameOfLifeReductionism;

namespace GameOfLifeReductionism.Test
{
    [TestFixture]
    public class GameOfLifeTest
    {
        private INeighboursCount neighboursCount;
        private ICellStateSolver cellStateSolver;
        private string[] panel;
        [TestCase]
        public void Test1()
        {          

            

            var game = Create();

            game.Next();

            A.CallTo(() => neighboursCount.GetCount(panel, A<int>.Ignored, A<int>.Ignored))
                .MustHaveHappened(Repeated.Exactly.Times(16));
        }

        [SetUp]
        public void Setup()
        {
            panel = new string[]{
                "----",
                "----",
                "----",
                "----",
            };
            neighboursCount = A.Fake<INeighboursCount>();
            cellStateSolver = A.Fake<ICellStateSolver>();
        }

        private GameOfLife Create()
        {
            var game = new GameOfLife(panel, neighboursCount, cellStateSolver);
            return game;
        }

        [TestCase]
        public void Test2()
        {
            var game = Create();
            A.CallTo(() => neighboursCount.GetCount(panel, A<int>.Ignored, A<int>.Ignored)).Returns(125);
            
            game.Next();

            A.CallTo(() => cellStateSolver.GetNextState(125))
                .MustHaveHappened(Repeated.Exactly.Times(16));

        }

        [TestCase]
        public void Test3()
        {
            A.CallTo(() => cellStateSolver.GetNextState(A<int>.Ignored)).ReturnsNextFromSequence(
                new []{'1','2','3','4','5','6','7','8','9','A','B','C','D','E','F','G'});
            var game = Create();            

            var result = game.Next();
            CollectionAssert.AreEqual(
                new string[]{
                    "1234",
                    "5678",
                    "9ABC",
                    "DEFG"
                },
                result);
        }
    }
}
