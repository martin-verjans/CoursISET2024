using System.Drawing;

namespace TicTacToeGame
{
    public interface IGameController
    {
        IGameUI GameUI { get; set; }

        void NewGame();
        void PlaceToken(Point cell);
    }
}