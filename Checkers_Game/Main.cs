using System.Drawing;
using Checkers_Controls;
using Checkers_Controls.GameRules;
using System.Windows.Forms;
using System;

namespace Checkers_Game
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GameIA.Instance.Initialized += GameIA_Initialized;
            GameIA.Instance.NextPlayerChanged += GameIA_NextPlayerChanged;

            GameIA.Instance.Board = gameboard;
            GameIA.Instance.Rules = new Spanish();
        }

        private void GameIA_Initialized(object sender, EventArgs e)
        {
        }

        private void GameIA_NextPlayerChanged(object sender, System.EventArgs e)
        {
            lblWhitesPlayer.ForeColor = Color.Gray;
            lblScoreWhites.ForeColor = Color.Gray;

            lblBlacksPlayer.ForeColor = Color.Gray;
            lblScoreBlacks.ForeColor = Color.Gray;

            if (GameIA.Instance.CurrentPlayer == GameIA.Instance.Whites)
            {
                lblWhitesPlayer.ForeColor = Color.DarkOrange;
                lblScoreWhites.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblBlacksPlayer.ForeColor = Color.DarkOrange;
                lblScoreBlacks.ForeColor = Color.DarkOrange;
            }
        }
        private void GameIA_BlacksScoreChanged(object sender, System.EventArgs e)
        {
            lblScoreBlacks.Text = GameIA.Instance.Blacks.Score.ToString("00");
        }
        private void GameIA_WhitesScoreChanged(object sender, System.EventArgs e)
        {
            lblScoreWhites.Text = GameIA.Instance.Whites.Score.ToString("00");
        }

        private void restartToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            gameboard.Controls.Clear();
            var startGame = new StartGameForm();
            if (startGame.ShowDialog() == DialogResult.OK)
            {
                GameIA.Instance.Blacks.ScoreChanged -= GameIA_BlacksScoreChanged;
                GameIA.Instance.Whites.ScoreChanged -= GameIA_WhitesScoreChanged;
                GameIA.Instance.InitializeGame();
                GameIA.Instance.Blacks.ScoreChanged += GameIA_BlacksScoreChanged;
                GameIA.Instance.Whites.ScoreChanged += GameIA_WhitesScoreChanged;
            }
        }

        private void changePlayerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GameIA.Instance.SetNextPlayer();
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            var startGame = new StartGameForm();
            if (startGame.ShowDialog() == DialogResult.OK)
            {
                GameIA.Instance.InitializeGame();
                GameIA.Instance.Blacks.ScoreChanged += GameIA_BlacksScoreChanged;
                GameIA.Instance.Whites.ScoreChanged += GameIA_WhitesScoreChanged;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
