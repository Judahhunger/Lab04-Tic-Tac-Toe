using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    class GameBoard
    {
        static string[,] MakeDefualtBoard()
        {
            string[,] defualtArray = new string[,] { { "| 1 |", "| 2 |", "| 3 |" }, { "| 4 |", "| 5 |", "| 6 |" }, { "| 7 |", "| 8 |", "| 9 |" }};
            return defualtArray;
        }
        
    }
}
