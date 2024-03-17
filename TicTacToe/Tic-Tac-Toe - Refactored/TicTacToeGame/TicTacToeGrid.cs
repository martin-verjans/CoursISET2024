using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using TicTacToeGame.GameExceptions;

namespace TicTacToeGame
{
    internal class TicTacToeGrid
    {
        private static readonly int[] tokens = { 0, -1, 1 };

        private readonly int gridSize;
        private readonly int[,] grid;

        private readonly int[] horizontalSum;
        private readonly int[] verticalSum;
        private readonly int[] diagonalSum;

        public bool GameIsFinished => (grid.Cast<int>().All(x => x != 0)) || Player1Won || Player2Won;
        public bool Player1Won => CheckWin(tokens[1]);
        public bool Player2Won => CheckWin(tokens[2]);

        public TicTacToeGrid(int gridSize)
        {
            this.gridSize = gridSize;
            grid = new int[gridSize, gridSize];
            horizontalSum = new int[gridSize];
            verticalSum = new int[gridSize];
            diagonalSum = new int[2];
        }

        public void ResetGrid()
        {
            Array.Clear(grid, 0, grid.Length);
            Array.Clear(horizontalSum, 0, horizontalSum.Length);
            Array.Clear(verticalSum, 0, verticalSum.Length);
            Array.Clear(diagonalSum, 0, diagonalSum.Length);
        }

        public void PlaceToken(PlayerNumbers player, Point cell)
        {
            ThrowIfInvalid(player, cell);
            int token = tokens[(int)player];
            grid[cell.X, cell.Y] = token;
            UpdateSums(token, cell);
        }

        private void ThrowIfInvalid(PlayerNumbers player, Point cell)
        {
            if (player == PlayerNumbers.Nobody)
            {
                throw new InvalidPlayerException();
            }
            if (GameIsFinished)
            {
                throw new GameFinishedException();
            }
            if (IsCellAlreadyPlayed(cell))
            {
                throw new InvalidMovementException(player, cell);
            }
        }

        private bool IsCellAlreadyPlayed(Point cell)
        {
            return grid[cell.X, cell.Y] != tokens[0];
        }

        private void UpdateSums(int token, Point cell)
        {
            horizontalSum[cell.X] += token;
            Debug.WriteLine($"Horizontal sums : {string.Join(", ", horizontalSum)}");

            verticalSum[cell.Y] += token;
            Debug.WriteLine($"Vertical sums : {string.Join(", ", verticalSum)}");

            if (cell.X == cell.Y)
            {
                diagonalSum[0] += token;
            }
            if (cell.X == gridSize - cell.Y - 1)
            {
                diagonalSum[1] += token;
            }
            Debug.WriteLine($"Diagonal sums : {string.Join(", ", diagonalSum)}");
        }

        private bool CheckWin(int token)
        {
            int count = token * gridSize;

            return 
                CheckArrayForWin(horizontalSum, count) || 
                CheckArrayForWin(verticalSum, count) ||
                CheckArrayForWin(diagonalSum, count);
        }

        private bool CheckArrayForWin(int[] toCheck, int count)
        {
            return toCheck.Any(x => x == count);
        }
    }
}
