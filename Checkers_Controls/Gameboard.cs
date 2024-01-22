using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Checkers_Controls
{
    public partial class Gameboard : UserControl
    {
        public Gameboard()
        {
            InitializeComponent();

            GameIA.Instance.GameModeChanged += GameIA_GameModeChanged;
            GameIA.Instance.NextPlayerChanged += GameIA_NextPlayerChanged;
        }
        
        public void GameIA_GameModeChanged(object sender, EventArgs e)
        {
            var currentMode = GameIA.Instance.Rules.Mode;
            Size = new Size(CaseControl.FixedSize * (int)currentMode, CaseControl.FixedSize * (int)currentMode);
            Invalidate();
        }

        public void GameIA_NextPlayerChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Game board::GameIA_NextInstance event triggered");
        }

        /// <summary>
        /// Gets the <see cref="CaseControl"/> found at the location point
        /// </summary>
        /// <param name="location">The point where find the control to return</param>
        /// <returns>The <see cref="CaseControl"/> found at the location point</returns>
        public CaseControl GetCaseControl(Point location)
        {
            return Controls.OfType<CaseControl>().SingleOrDefault(cc => cc.Location.X == location.X * 50 && cc.Location.Y == location.Y * 50);
        }
    }
}
