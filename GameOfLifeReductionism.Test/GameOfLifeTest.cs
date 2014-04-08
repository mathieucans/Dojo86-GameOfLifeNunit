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
        private IPanelConverter panelConverter;
      

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
            panelConverter = A.Fake<IPanelConverter>();
        }

        private GameOfLife Create()
        {
            var game = new GameOfLife(panel, neighboursCount, cellStateSolver, panelConverter);
            return game;
        }

        [TestCase]
        public void NeighboursCountIsCalledFoEachCell()
        {
            var game = Create();
            var fakeList = new List<Cell>();
            A.CallTo(() => panelConverter.Convert(panel)).Returns(fakeList);

            game.Next();

            A.CallTo(() => neighboursCount.GetCount(fakeList, A<int>.Ignored, A<int>.Ignored))
                .MustHaveHappened(Repeated.Exactly.Times(16));
        }

        [TestCase]
        public void Next_WhenNeigbOursCountIs125ForAllCell_CountIsWellPassedToSolver()
        {
            var game = Create();
            var fakeList = new List<Cell>();
            A.CallTo(() => panelConverter.Convert(panel)).Returns(fakeList);
            A.CallTo(() => neighboursCount.GetCount(fakeList, A<int>.Ignored, A<int>.Ignored)).Returns(125);
            
            game.Next();

            A.CallTo(() => cellStateSolver.GetNextState(A<char>.Ignored, 125))
                .MustHaveHappened(Repeated.Exactly.Times(16));

        }

        [TestCase]
        public void AllNewStatesAreUsedInTheFinalState()
        {
            A.CallTo(() => cellStateSolver.GetNextState(A<char>.Ignored, A<int>.Ignored)).ReturnsNextFromSequence(
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
