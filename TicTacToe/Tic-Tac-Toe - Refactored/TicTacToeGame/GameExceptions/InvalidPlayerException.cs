using System;

namespace TicTacToeGame.GameExceptions
{
    internal class InvalidPlayerException : TicTacToeException
    {
        public InvalidPlayerException()
            :base($"Invalid Player (Nobody) !")
        {
        }
    }
}