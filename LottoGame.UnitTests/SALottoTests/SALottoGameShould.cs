using LottoGame;
using LottoGame.Games;
using LottoGame.ConcreteGames;
using LottoGame.ConcreteGames.DivisionFactory;
using System;
using Xunit;


namespace LottoGame.UnitTests
{
    public class SALottoGameShould
    {
        SALottoDivisions divisionFactory = new SALottoDivisions();
        GameFactory gameFactory;

        public SALottoGameShould()
        {
            gameFactory = new SALotto(divisionFactory);
        }

        [Fact]
        public void GetDivision1()
        {
            var division = gameFactory.CaptureGame(new int[] { 1, 6, 10, 18, 21, 32, 7 });
            Assert.Equal("Winner – Division 1", division);
        }

        [Fact]
        public void GetDivision2()
        {
            var division = gameFactory.CaptureGame(new int[] { 1, 6, 10, 18, 19, 28, 7 });
            Assert.Equal("Winner – Division 2", division);
        }

        [Fact]
        public void GetDivision3()
        {
            var division = gameFactory.CaptureGame(new int[] { 1, 6, 10, 18, 19, 30, 20 });
            Assert.Equal("Winner – Division 3", division);
        }

        [Fact]
        public void GetDivision4()
        {
            var division = gameFactory.CaptureGame(new int[] { 1, 6, 10, 18, 20, 25, 7 });
            Assert.Equal("Winner – Division 4", division);
        }

        [Fact]
        public void GetDivision5()
        {
            var division = gameFactory.CaptureGame(new int[] { 1, 6, 10, 18, 20, 25, 3 });
            Assert.Equal("Winner – Division 5", division);
        }
        [Fact]
        public void GetDivision6()
        {
            var division = gameFactory.CaptureGame(new int[] { 1, 6, 10, 16, 24, 30, 7 });
            Assert.Equal("Winner – Division 6", division);
        }

        [Fact]
        public void GetDivision7()
        {
            var division = gameFactory.CaptureGame(new int[] { 1, 6, 10, 16, 24, 30, 10 });
            Assert.Equal("Winner – Division 7", division);
        }

        [Fact]
        public void GetDivision8()
        {
            var division = gameFactory.CaptureGame(new int[] { 1, 6, 7, 19, 25, 28, 7 });
            Assert.Equal("Winner – Division 8", division);
        }

        [Fact]
        public void GetNotAWinner()
        {
            var division = gameFactory.CaptureGame(new int[] { 3, 4, 6, 3, 18, 21, 32 });
            Assert.Equal("Not a winner", division);
        }
    }
}
