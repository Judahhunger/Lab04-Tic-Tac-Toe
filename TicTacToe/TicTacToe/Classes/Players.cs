using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    public class Players
    {
        /// <summary>
        /// Stores players name
        /// </summary>
        public string PlayerName { get; set; }

        /// <summary>
        /// Stores players game marker
        /// </summary>
        public string PlayerGamePiece { get; set; }


        /// <summary>
        /// stores the positions they players have chossen.
        /// </summary>
        public string[] PlayerPositions { get; set; }

        
        public Players(string name, string marker)
        {
            PlayerName = name;
            PlayerGamePiece = marker;
        }

    }
}
