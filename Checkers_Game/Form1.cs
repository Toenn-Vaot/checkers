using Checkers_Controls;
using Checkers_Controls.GameRules;
using System.Windows.Forms;

namespace Checkers_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            GameIA.Instance.NextPlayerChanged += GameIA_NextPlayerChanged;

            GameIA.Instance.Board = gameboard1;
            GameIA.Instance.Rules = new International();
            GameIA.Instance.InitializeGame("Tom", "Harry");
        }

        private void GameIA_NextPlayerChanged(object sender, System.EventArgs e)
        {
            lblWhitesPlayer.ForeColor = System.Drawing.Color.Gray;
            lblBlacksPlayer.ForeColor = System.Drawing.Color.Gray;

            if (GameIA.Instance.NextPlayer == GameIA.Instance.Whites)
                lblWhitesPlayer.ForeColor = System.Drawing.Color.White;
            else
                lblBlacksPlayer.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            GameIA.Instance.SetNextPlayer();
        }
    }
}
