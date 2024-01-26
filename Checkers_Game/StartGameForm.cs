using System;
using System.Windows.Forms;
using Checkers_Controls;
using Checkers_Controls.GameRules;
using Checkers_Game.Properties;

namespace Checkers_Game
{
    public partial class StartGameForm : Form
    {
        public StartGameForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }

        private void StartGameForm_Load(object sender, EventArgs e)
        {
            GameIA.Instance.Rules = new International();
            lblWhitesPlayer.TabStop = false;
            pawnPlayerWhites.TabStop = false;
            lblBlacksPlayer.TabStop = false;
            pawnPlayerBlacks.TabStop = false;
        }

        private void rdRule_CheckedChanged(object sender, EventArgs e)
        {
            var control = ((RadioButton)sender);
            if (control.Checked)
            {
                switch (control.Tag.ToString())
                {
                    case "UK":
                        GameIA.Instance.Rules = new English();
                        break;
                    case "ES":
                        GameIA.Instance.Rules = new Spanish();
                        break;
                    case "DE":
                        GameIA.Instance.Rules = new German();
                        break;
                    case "IT":
                        GameIA.Instance.Rules = new Italian();
                        break;
                    case "NL":
                        GameIA.Instance.Rules = new Dutch();
                        break;
                    case "RU":
                        GameIA.Instance.Rules = new Russian();
                        break;
                    case "CA":
                        GameIA.Instance.Rules = new Canadian();
                        break;
                    default:
                        GameIA.Instance.Rules = new International();
                        break;
                }
            }
        }
    }
}
