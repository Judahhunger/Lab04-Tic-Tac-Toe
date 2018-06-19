using System;
using Xunit;
using TicTacToe.Classes;

namespace TicTacToeTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new string[] { "1", "2", "3" }, new string[] { "1", "2", "3" }, true)]
        [InlineData(new string[] { "3", "4", "9" }, new string[] { "3", "4", "9" }, true)]
        [InlineData(new string[] { "1", "2", "5" }, new string[] { "1", "2", "5" }, true)]
        public void TestForWinner(string[] board, string[] positions, bool value)
        {
            Players test1 = new Players("John","X");
            test1.PlayerPositions = new string[] { "1", "2", "3", "5" };

            Players test2 = new Players("Doe", "O");
            test2.PlayerPositions = new string[] { "3", "4", "9", "7" };

            Game testGame = new Game();

            Assert.Equal(value, testGame.CheckForWinner(test1, test2));
        }

        [Fact]
        public void CheckforTurns()
        {
            string player1 = "Jack";
            string player2 = "Jill";
            string currentplayer = "";
            int counter = 1;
                if (counter % 2 == 0)
                {
                currentplayer = player1;
                }
            if (counter % 2 != 0)
            {
                currentplayer = player2;
            }
              
            Assert.Equal("Jill", currentplayer);
        }

        [Fact]
        public void CheckGameSpots()
        {
            Players test1 = new Players("John", "X");
            test1.PlayerPositions = new string[] { "1", "2", "3"};

            Players test2 = new Players("Doe", "O");
            test2.PlayerPositions = new string[4];

            GameBoard testBoard = new GameBoard();
            string[,] boardToTest = testBoard.DefualtBoard;

            testBoard.UpdateGamePositions(test1, test2, boardToTest);

            string[,] playTest = {
            { "X", "X", "X" },
            { "4", "5", "6" },
            { "7", "8", "9" } };

            Assert.Equal(playTest, boardToTest);
        }
    }
}
