namespace Checkers_Game
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBlacksPlayer = new System.Windows.Forms.Label();
            this.lblWhitesPlayer = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblScoreBlacks = new System.Windows.Forms.Label();
            this.lblScoreWhites = new System.Windows.Forms.Label();
            this.gameboard1 = new Checkers_Controls.Gameboard();
            this.pawnPlayerWhites = new Checkers_Controls.PawnControl();
            this.pawnPlayerBlacks = new Checkers_Controls.PawnControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBlacksPlayer
            // 
            this.lblBlacksPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlacksPlayer.Location = new System.Drawing.Point(12, 59);
            this.lblBlacksPlayer.Name = "lblBlacksPlayer";
            this.lblBlacksPlayer.Size = new System.Drawing.Size(176, 25);
            this.lblBlacksPlayer.TabIndex = 1;
            this.lblBlacksPlayer.Text = "BLACKS";
            this.lblBlacksPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhitesPlayer
            // 
            this.lblWhitesPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhitesPlayer.Location = new System.Drawing.Point(700, 59);
            this.lblWhitesPlayer.Name = "lblWhitesPlayer";
            this.lblWhitesPlayer.Size = new System.Drawing.Size(172, 25);
            this.lblWhitesPlayer.TabIndex = 1;
            this.lblWhitesPlayer.Text = "WHITES";
            this.lblWhitesPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cheatsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "&Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // cheatsToolStripMenuItem
            // 
            this.cheatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePlayerToolStripMenuItem});
            this.cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
            this.cheatsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cheatsToolStripMenuItem.Text = "&Cheats";
            // 
            // changePlayerToolStripMenuItem
            // 
            this.changePlayerToolStripMenuItem.Name = "changePlayerToolStripMenuItem";
            this.changePlayerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.changePlayerToolStripMenuItem.Text = "C&hange player";
            this.changePlayerToolStripMenuItem.Click += new System.EventHandler(this.changePlayerToolStripMenuItem_Click);
            // 
            // lblScoreBlacks
            // 
            this.lblScoreBlacks.AutoSize = true;
            this.lblScoreBlacks.BackColor = System.Drawing.Color.Chocolate;
            this.lblScoreBlacks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScoreBlacks.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreBlacks.Location = new System.Drawing.Point(194, 59);
            this.lblScoreBlacks.Name = "lblScoreBlacks";
            this.lblScoreBlacks.Size = new System.Drawing.Size(99, 80);
            this.lblScoreBlacks.TabIndex = 1;
            this.lblScoreBlacks.Text = "00";
            this.lblScoreBlacks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreWhites
            // 
            this.lblScoreWhites.AutoSize = true;
            this.lblScoreWhites.BackColor = System.Drawing.Color.Chocolate;
            this.lblScoreWhites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScoreWhites.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreWhites.Location = new System.Drawing.Point(595, 59);
            this.lblScoreWhites.Name = "lblScoreWhites";
            this.lblScoreWhites.Size = new System.Drawing.Size(99, 80);
            this.lblScoreWhites.TabIndex = 1;
            this.lblScoreWhites.Text = "00";
            this.lblScoreWhites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameboard1
            // 
            this.gameboard1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gameboard1.Location = new System.Drawing.Point(194, 167);
            this.gameboard1.Margin = new System.Windows.Forms.Padding(10);
            this.gameboard1.Name = "gameboard1";
            this.gameboard1.Size = new System.Drawing.Size(500, 500);
            this.gameboard1.TabIndex = 0;
            // 
            // pawnPlayerWhites
            // 
            this.pawnPlayerWhites.BackColor = System.Drawing.Color.Transparent;
            this.pawnPlayerWhites.Color = Checkers_Library.Enumerations.GameColor.White;
            this.pawnPlayerWhites.HasGloups = false;
            this.pawnPlayerWhites.IsGloupsed = false;
            this.pawnPlayerWhites.IsQueen = false;
            this.pawnPlayerWhites.Location = new System.Drawing.Point(761, 89);
            this.pawnPlayerWhites.MaximumSize = new System.Drawing.Size(50, 50);
            this.pawnPlayerWhites.MinimumSize = new System.Drawing.Size(50, 50);
            this.pawnPlayerWhites.Name = "pawnPlayerWhites";
            this.pawnPlayerWhites.Size = new System.Drawing.Size(50, 50);
            this.pawnPlayerWhites.TabIndex = 6;
            // 
            // pawnPlayerBlacks
            // 
            this.pawnPlayerBlacks.BackColor = System.Drawing.Color.Black;
            this.pawnPlayerBlacks.Color = Checkers_Library.Enumerations.GameColor.Black;
            this.pawnPlayerBlacks.HasGloups = false;
            this.pawnPlayerBlacks.IsGloupsed = false;
            this.pawnPlayerBlacks.IsQueen = false;
            this.pawnPlayerBlacks.Location = new System.Drawing.Point(75, 87);
            this.pawnPlayerBlacks.MaximumSize = new System.Drawing.Size(50, 50);
            this.pawnPlayerBlacks.MinimumSize = new System.Drawing.Size(50, 50);
            this.pawnPlayerBlacks.Name = "pawnPlayerBlacks";
            this.pawnPlayerBlacks.Size = new System.Drawing.Size(50, 50);
            this.pawnPlayerBlacks.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(884, 735);
            this.Controls.Add(this.pawnPlayerBlacks);
            this.Controls.Add(this.pawnPlayerWhites);
            this.Controls.Add(this.lblWhitesPlayer);
            this.Controls.Add(this.lblScoreWhites);
            this.Controls.Add(this.lblScoreBlacks);
            this.Controls.Add(this.lblBlacksPlayer);
            this.Controls.Add(this.gameboard1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Checkers_Controls.Gameboard gameboard1;
        private System.Windows.Forms.Label lblBlacksPlayer;
        private System.Windows.Forms.Label lblWhitesPlayer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblScoreBlacks;
        private System.Windows.Forms.Label lblScoreWhites;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePlayerToolStripMenuItem;
        private Checkers_Controls.PawnControl pawnPlayerWhites;
        private Checkers_Controls.PawnControl pawnPlayerBlacks;
    }
}

