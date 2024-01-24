using System.Drawing;
using Checkers_Controls;
using Checkers_Controls.GameRules;
using System.Windows.Forms;
using System.Reflection.Emit;
using System;

namespace Checkers_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            GameIA.Instance.Initialized += GameIA_Initialized;
            GameIA.Instance.NextPlayerChanged += GameIA_NextPlayerChanged;

            GameIA.Instance.Board = gameboard1;
            GameIA.Instance.Rules = new International();
            GameIA.Instance.InitializeGame("Tom", "Harry");
            GameIA.Instance.Blacks.ScoreChanged += GameIA_BlacksScoreChanged;
            GameIA.Instance.Whites.ScoreChanged += GameIA_WhitesScoreChanged;
        }

        private void GameIA_Initialized(object sender, EventArgs e)
        {
            lblBlacksPlayer.Text = GameIA.Instance.Blacks.Name;
            lblWhitesPlayer.Text = GameIA.Instance.Whites.Name;
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
            GameIA.Instance.InitializeGame("Tom", "Harry");
            GameIA.Instance.Blacks.ScoreChanged += GameIA_BlacksScoreChanged;
            GameIA.Instance.Whites.ScoreChanged += GameIA_WhitesScoreChanged;
        }

        private void changePlayerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GameIA.Instance.SetNextPlayer();
        }
    }
}
