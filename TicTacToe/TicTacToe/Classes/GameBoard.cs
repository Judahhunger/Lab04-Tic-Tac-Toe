using System;
using System.Collections.Generic;
using System.Text;


namespace TicTacToe.Classes
{
    public class GameBoard
    {
        /// <summary>
        /// DefualtBoard is a 2d array with preset values.
        /// </summary>
        public string[,] DefualtBoard = {
            { "1", "2", "3" },
            { "4", "5", "6" }, 
            { "7", "8", "9" } };


        /// <summary>
        /// Takes in 2d array and draws board to console.
        /// </summary>
        /// <param name="board"></param>
        public void ShowBoard(string[,] board)
        {
            int counter = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"| {board[counter, j]} |");

                }
                Console.WriteLine();
                counter++;
            }          
        }

        /// <summary>
        /// every time a player inputs what spot to put marker it'll update board by finding the index values.
        /// </summary>
        /// <param name="firstPlayer"></param>
        /// <param name="secondPlayer"></param>
        /// <param name="gameBoard"></param>
        public void UpdateGamePositions(Players firstPlayer, Players secondPlayer, string[,] gameBoard)
        {
            try
            {
                foreach (string item in firstPlayer.PlayerPositions)
                {
                    if (item != null && item != "")
                    {
                        for (int i = 0; i < gameBoard.GetLength(0); i++)
                        {
                            for (int j = 0; j < gameBoard.GetLength(1); j++)
                            {
                                if (gameBoard[i, j].Contains(item))
                                {
                                    gameBoard[i, j] = firstPlayer.PlayerGamePiece;
                                }
                            }
                        }
                    }                   
                }


                foreach (string item in secondPlayer.PlayerPositions)
                {
                    if (item != null && item != "")
                    {
                        for (int i = 0; i < gameBoard.GetLength(0); i++)
                        {
                            for (int j = 0; j < gameBoard.GetLength(1); j++)
                            {
                                if (gameBoard[i, j].Contains(item))
                                {
                                    gameBoard[i, j] = secondPlayer.PlayerGamePiece;
                                }
                            }
                        }
                    }
                   
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
       
        }
        
    }
}
