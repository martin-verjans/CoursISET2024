using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private const string TEXT_ERROR_CELL_TAKEN = "Vous ne pouvez pas cliquer ici, la case a déja été prise";
        private bool player1Turn = true;
        private int[,] gameGrid = new int[3, 3];

        private readonly Button[] buttons;

        public Form1()
        {
            InitializeComponent();
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

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameGrid[i, j] = 0;
                }
            }

            InitButtons();
        }

        private void InitButtons()
        {
            foreach(Button b in buttons)
            {
                b.Enabled = false; 
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            PrepareNewGame();
        }

        private void PrepareNewGame()
        {
            player1Turn = true;
            lblStatusText.Text = "Joueur 1, cliquez sur une case";

            //init de la grille
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameGrid[i, j] = 0;
                    
                }
            }

            foreach(Button cellButton in buttons)
            {
                InitButton(cellButton);
            }
        }

        private void InitButton(Button toInit)
        {
            toInit.ImageIndex = 0;
            toInit.Enabled = true;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            Point coordinatesButton = (Point)clicked.Tag;
            PlaceToken(clicked, coordinatesButton);
        }

        private void PlaceToken(Button clickedButton, Point cell)
        {
            if (!CellIsFree(cell))
            {
                DisplayErrorCellTaken();
                return;
            }

            UpdateGameGrid(GetCurrentPlayerNumber(), cell);

            UpdateUI(GetCurrentPlayerNumber(), clickedButton);

            CheckWin();

            SwitchPlayerTurn();
        }

        private void UpdateUI(int playerNumber, Button clickedButton)
        {
            clickedButton.ImageIndex = playerNumber;
            clickedButton.Enabled = false;
            lblStatusText.Text = $"Joueur {playerNumber}, cliquez sur une case";
        }

        private static void DisplayErrorCellTaken()
        {
            MessageBox.Show(TEXT_ERROR_CELL_TAKEN);
            Debug.Write(TEXT_ERROR_CELL_TAKEN);
        }

        private int GetCurrentPlayerNumber()
        {
            return player1Turn ? 1 : 2;
        }

        private void SwitchPlayerTurn()
        {
            player1Turn = !player1Turn;
        }

        private void UpdateGameGrid(int playerNumber, Point cell)
        {
            gameGrid[cell.X, cell.Y] = playerNumber;
        }

        private bool CellIsFree(Point cell)
        {
            return gameGrid[cell.X, cell.Y] == 0;
        }

        private void CheckWin()
        {
            btnNewGame.Focus();
            if ((gameGrid[0, 0] == 1 && gameGrid[0, 1] == 1 && gameGrid[0, 2] == 1) || //Horizontales
                (gameGrid[1, 0] == 1 && gameGrid[1, 1] == 1 && gameGrid[1, 2] == 1) ||
                (gameGrid[2, 0] == 1 && gameGrid[2, 1] == 1 && gameGrid[2, 2] == 1) ||
                (gameGrid[0, 0] == 1 && gameGrid[1, 0] == 1 && gameGrid[2, 0] == 1) ||
                (gameGrid[0, 1] == 1 && gameGrid[1, 1] == 1 && gameGrid[2, 1] == 1) ||//Verticales
                (gameGrid[0, 2] == 1 && gameGrid[1, 2] == 1 && gameGrid[2, 2] == 1) ||
                (gameGrid[0, 0] == 1 && gameGrid[1, 1] == 1 && gameGrid[2, 2] == 1) ||//Diagonales
                (gameGrid[0, 2] == 1 && gameGrid[1, 1] == 1 && gameGrid[2, 0] == 1))
            {
                DeclarerVainqueur(1);
            }
            if ((gameGrid[0, 0] == 2 && gameGrid[0, 1] == 2 && gameGrid[0, 2] == 2) ||
                (gameGrid[1, 0] == 2 && gameGrid[1, 1] == 2 && gameGrid[1, 2] == 2) ||
                (gameGrid[2, 0] == 2 && gameGrid[2, 1] == 2 && gameGrid[2, 2] == 2) ||
                (gameGrid[0, 0] == 2 && gameGrid[1, 0] == 2 && gameGrid[2, 0] == 2) ||
                (gameGrid[0, 1] == 2 && gameGrid[1, 1] == 2 && gameGrid[2, 1] == 2) ||
                (gameGrid[0, 2] == 2 && gameGrid[1, 2] == 2 && gameGrid[2, 2] == 2) ||
                (gameGrid[0, 0] == 2 && gameGrid[1, 1] == 2 && gameGrid[2, 2] == 2) ||
                (gameGrid[0, 2] == 2 && gameGrid[1, 1] == 2 && gameGrid[2, 0] == 2))
            {
                DeclarerVainqueur(2);
            }
        }

        private void DeclarerVainqueur(int player)
        {
            MessageBox.Show($"Joueur {player} a gagné !");

            lblStatusText.Text = "Appuyez sur New Game";
        }
    }
}
