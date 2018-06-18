using System;
using System.IO;
using TicTacToe.Classes;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Play a game of Tic Tack Toe");
            PlayTicTacToe();
        }

        /// <summary>
        /// Makes player one with name and marker
        /// </summary>
        /// <returns>Player one</returns>
        public static Players GetPlayerOne()
        {
            Console.WriteLine("Player one please enter your name");
            string playerOneName = Console.ReadLine();
            Console.WriteLine($"{playerOneName} You are X's");
            Console.ReadLine();
            Console.Clear();

            Players playerOne = new Players(playerOneName, "X");
            playerOne.PlayerPositions = new string[5];

            return playerOne;
        }

        /// <summary>
        /// Makes player two with name and marker
        /// </summary>
        /// <returns>Player two</returns>
        public static Players GetPlayerTwo()
        {
            Console.WriteLine("Player two please enter your name");
            string playerTwoName = Console.ReadLine();
            Console.WriteLine($"{playerTwoName} You are O's");
            Console.ReadLine();
            Console.Clear();

            Players playerTwo = new Players(playerTwoName, "O");
            playerTwo.PlayerPositions = new string[4];
            return playerTwo;
        }

        /// <summary>
        /// Gets players, board and starts game.
        /// </summary>
        public static void PlayTicTacToe()
        {
            Players readyPlayerOne = GetPlayerOne();
            Players readyPlayerTwo = GetPlayerTwo();
            GameBoard mainGameBoard = new GameBoard();

            string[,] newGameBoard = mainGameBoard.DefualtBoard;

            Game game = new Game();
            game.PlayerOne = readyPlayerOne;
            game.PlayerTwo = readyPlayerTwo;

            // winner = false;
            int counter = 0; // game counter
            int playOneCount = 0;//makes index in array for player one
            int playTwoCount = 0;//makes index in array for player two
            while (game.Winner == false && counter < 9)
            {
                mainGameBoard.ShowBoard(newGameBoard);
               
                if (counter % 2 == 0)
                {
                    
                    Console.WriteLine($"{readyPlayerOne.PlayerName} please choose a position");
                    string playerOnePositionSelected = Console.ReadLine();
                    readyPlayerOne.PlayerPositions[playOneCount] = playerOnePositionSelected;
                    mainGameBoard.UpdateGamePositions(readyPlayerOne, readyPlayerTwo, newGameBoard);
                    playOneCount++;
                    counter++;
  
                }
                else
                { 
                    Console.WriteLine($"{readyPlayerTwo.PlayerName} please choose a position");
                    string playerTwoPositionSelected = Console.ReadLine();
                    readyPlayerTwo.PlayerPositions[playTwoCount] = playerTwoPositionSelected;
                    mainGameBoard.UpdateGamePositions(readyPlayerOne, readyPlayerTwo, newGameBoard);
                    playTwoCount++;
                    counter++;  
                }

                game.Winner = game.CheckForWinner(readyPlayerOne, readyPlayerTwo);
               
            }
            if (game.Winner == true)
            {
                PlayAgain();
            }
            Console.WriteLine("the match was a draw");
            Console.ReadLine();
            PlayAgain();
        }

        /// <summary>
        /// asks if players want to start again and if they do starts new game if not exits app.
        /// </summary>
        public static void PlayAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("1) play again");
            Console.WriteLine("2) to exit app");
            string playAgainOrNot = Console.ReadLine();

            switch (playAgainOrNot)
            {
                case "1":
                    PlayTicTacToe();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
       
    }
}
