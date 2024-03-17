using System.Drawing;

namespace TicTacToeGame
{
    internal class GameController : IGameController
    {
        private readonly TicTacToeGrid grid;

        private PlayerNumbers currentPlayer;

        private PlayerNumbers WinnerPlayer
        {
            get
            {
                if (grid.Player1Won)
                    return PlayerNumbers.Player1;
                if (grid.Player2Won)
                    return PlayerNumbers.Player2;
                return PlayerNumbers.Nobody;
            }
        }

        public IGameUI GameUI { get; set; }

        public GameController(int gridSize)
        {
            grid = new TicTacToeGrid(gridSize);
            currentPlayer = PlayerNumbers.Nobody;
        }

        public void NewGame()
        {
            grid.ResetGrid();
            currentPlayer = PlayerNumbers.Player1;
            GameUI?.InitGame();
            GameUI?.UpdatePlayerTurnText(currentPlayer);
        }

        public void PlaceToken(Point cell)
        {
            grid.PlaceToken(currentPlayer, cell);
            GameUI?.GiveCellToPlayer(cell, currentPlayer);

            if (grid.GameIsFinished)
            {
                GameUI?.DeclareWinner(WinnerPlayer);
                return;
            }

            SwitchCurrentPlayer();
            GameUI?.UpdatePlayerTurnText(currentPlayer);
        }

        private void SwitchCurrentPlayer()
        {
            currentPlayer = currentPlayer == PlayerNumbers.Player1 ? PlayerNumbers.Player2 : PlayerNumbers.Player1;
        }
    }
}
