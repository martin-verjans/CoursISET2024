using System.Drawing;

namespace TicTacToeGame
{
    public interface IGameUI
    {
        void InitGame();
        void UpdatePlayerTurnText(PlayerNumbers player);
        void GiveCellToPlayer(Point cell, PlayerNumbers player);
        void DeclareWinner(PlayerNumbers winner);
    }
}
