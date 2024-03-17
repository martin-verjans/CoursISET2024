using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TicTacToeGame;
using TicTacToeGame.GameExceptions;

namespace Tic_Tac_Toe
{
    public partial class GameForm : Form, IGameUI
    {
        public const int GAME_GRID_SIZE = 3;

        private readonly string[] displayPlayerTurn = { 
            "Cliquez sur Nouvelle Partie", 
            "Joueur 1, cliquez sur une case", 
            "Joueur 2, cliquez sur une case" 
        };
        private readonly string[] displayWinner = {
            "Il n'y a pas de gagnant !", 
            "Joueur 1 a gagné !",
            "Joueur 2 a gagné !"
        };

        private Button[] buttons;
        public IGameController GameController { get; set; }

        public GameForm()
        {
            InitializeComponent();
            InitButtons();
        }

        public void InitGame()
        {
            Array.ForEach(buttons, b => b.ImageIndex = 0);
            EnableButtons(true);
        }

        public void UpdatePlayerTurnText(PlayerNumbers player)
        {
            lblStatus.Text = displayPlayerTurn[(int)player];
        }

        public void GiveCellToPlayer(Point cell, PlayerNumbers player)
        {
            Button cellButton = buttons.First(b => (Point)b.Tag == cell);
            cellButton.ImageIndex = (int)player;
            cellButton.Enabled = false;
        }

        public void DeclareWinner(PlayerNumbers player)
        {
            EnableButtons(false);
            string displayText = displayWinner[(int)player];
            lblStatus.Text = displayText;
            MessageBox.Show(displayText);
        }

        private void InitButtons()
        {
            buttons = new Button[] { btn_0_0, btn_0_1, btn_0_2, btn_1_0, btn_1_1, btn_1_2, btn_2_0, btn_2_1, btn_2_2 };
            btn_0_0.Tag = new Point(0, 0);
            btn_0_1.Tag = new Point(0, 1);
            btn_0_2.Tag = new Point(0, 2);
            btn_1_0.Tag = new Point(1, 0);
            btn_1_1.Tag = new Point(1, 1);
            btn_1_2.Tag = new Point(1, 2);
            btn_2_0.Tag = new Point(2, 0);
            btn_2_1.Tag = new Point(2, 1);
            btn_2_2.Tag = new Point(2, 2);
            EnableButtons(false);
        }

        private void EnableButtons(bool enable)
        {
            Array.ForEach(buttons, b => b.Enabled = enable);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            GameController.NewGame();
        }

        private void btn_cell_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            Point cell = (Point)clicked.Tag;
            TryPlaceToken(cell);
        }

        private void TryPlaceToken(Point cell)
        {
            try
            {
                GameController.PlaceToken(cell);
            }
            catch (TicTacToeException ex)
            {
                MessageBox.Show(ex.Message, "Une erreur s'est produite");
            }
        }
    }
}
