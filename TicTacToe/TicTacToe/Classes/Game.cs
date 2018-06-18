using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    public class Game
    {

        public Players PlayerOne { get; set; }
        public Players PlayerTwo { get; set; }
        
        /// <summary>
        /// checks for winner of game.
        /// </summary>
        public bool Winner { get; set; }

        /// <summary>
        /// tests for winners from what posistions they have choosen stored in player array,
        /// compared to winning posistions.
        /// </summary>
        /// <param name="firstPlayer"></param>
        /// <param name="secondPlayers"></param>
        /// <returns></returns>
        public bool CheckForWinner(Players firstPlayer, Players secondPlayers)
        {
            string playerOneTestString = "";
            foreach (string item in firstPlayer.PlayerPositions)
            {
                if (item != null)
                {
                    playerOneTestString += $"{item} ";
                }
            }

            string playerTwoTestString = "";
            foreach (string item in secondPlayers.PlayerPositions)
            {
                if (item != null)
                {
                    playerTwoTestString += $"{item} ";
                }
            }

            if (playerOneTestString.Contains("1") && playerOneTestString.Contains("2") && playerOneTestString.Contains("3") ||
               playerOneTestString.Contains("4") && playerOneTestString.Contains("5") && playerOneTestString.Contains("6") ||
               playerOneTestString.Contains("7") && playerOneTestString.Contains("8") && playerOneTestString.Contains("9") ||
               playerOneTestString.Contains("1") && playerOneTestString.Contains("4") && playerOneTestString.Contains("7") ||
               playerOneTestString.Contains("2") && playerOneTestString.Contains("5") && playerOneTestString.Contains("8") ||
               playerOneTestString.Contains("3") && playerOneTestString.Contains("6") && playerOneTestString.Contains("9") ||
               playerOneTestString.Contains("1") && playerOneTestString.Contains("5") && playerOneTestString.Contains("9") ||
               playerOneTestString.Contains("3") && playerOneTestString.Contains("5") && playerOneTestString.Contains("7"))
            {
                Console.WriteLine($"{firstPlayer.PlayerName} has won");
                Winner = true;
                return true;
            }
            else if (playerTwoTestString.Contains("1") && playerTwoTestString.Contains("2") && playerTwoTestString.Contains("3") ||
               playerTwoTestString.Contains("4") && playerTwoTestString.Contains("5") && playerTwoTestString.Contains("6") ||
               playerTwoTestString.Contains("7") && playerTwoTestString.Contains("8") && playerTwoTestString.Contains("9") ||
               playerTwoTestString.Contains("1") && playerTwoTestString.Contains("4") && playerTwoTestString.Contains("7") ||
               playerTwoTestString.Contains("2") && playerTwoTestString.Contains("5") && playerTwoTestString.Contains("8") ||
               playerTwoTestString.Contains("3") && playerTwoTestString.Contains("6") && playerTwoTestString.Contains("9") ||
               playerTwoTestString.Contains("1") && playerTwoTestString.Contains("5") && playerTwoTestString.Contains("9") ||
               playerTwoTestString.Contains("3") && playerTwoTestString.Contains("5") && playerTwoTestString.Contains("7"))
            {
                Console.WriteLine($"{secondPlayers.PlayerName} has won");
                Winner = true;
                return true;
            }
            Winner = false;
            return false;

        }
       
    }
    
}
