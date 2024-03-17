using System.Drawing;

namespace TicTacToeGame.GameExceptions
{
    internal class InvalidMovementException : TicTacToeException
    {
        public PlayerNumbers Player { get; }
        public Point Cell { get; }

        public InvalidMovementException(PlayerNumbers player, Point cell)
            :base($"{player} cannot play in ({cell.X}, {cell.Y}), cell already played !")
        {
            Player = player;
            Cell = cell;
        }
    }
}