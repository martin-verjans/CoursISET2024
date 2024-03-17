using System;

namespace TicTacToeGame.GameExceptions
{
    public class TicTacToeException : Exception
    {
        public TicTacToeException(string message)
            : base(message)
        {
        }
    }
}
