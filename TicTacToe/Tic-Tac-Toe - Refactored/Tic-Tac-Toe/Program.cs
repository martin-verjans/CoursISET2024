using System;
using System.Windows.Forms;
using TicTacToeGame;

namespace Tic_Tac_Toe
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GameForm game = new GameForm();
            GameBuilder builder = new GameBuilder(game, GameForm.GAME_GRID_SIZE);
            game.GameController = builder.Build();

            Application.Run(game);
        }
    }
}
