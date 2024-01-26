namespace Checkers_Game
{
    partial class Main
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
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblScoreBlacks = new System.Windows.Forms.Label();
            this.lblScoreWhites = new System.Windows.Forms.Label();
            this.pawnPlayerBlacks = new Checkers_Controls.PawnControl();
            this.pawnPlayerWhites = new Checkers_Controls.PawnControl();
            this.gameboard = new Checkers_Controls.Gameboard();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBlacksPlayer
            // 
            this.lblBlacksPlayer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Checkers_Game.Properties.Settings.Default, "BlacksPlayerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblBlacksPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlacksPlayer.Location = new System.Drawing.Point(12, 59);
            this.lblBlacksPlayer.Name = "lblBlacksPlayer";
            this.lblBlacksPlayer.Size = new System.Drawing.Size(176, 25);
            this.lblBlacksPlayer.TabIndex = 1;
            this.lblBlacksPlayer.Text = global::Checkers_Game.Properties.Settings.Default.BlacksPlayerName;
            this.lblBlacksPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhitesPlayer
            // 
            this.lblWhitesPlayer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Checkers_Game.Properties.Settings.Default, "WhitesPlayerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblWhitesPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhitesPlayer.Location = new System.Drawing.Point(700, 59);
            this.lblWhitesPlayer.Name = "lblWhitesPlayer";
            this.lblWhitesPlayer.Size = new System.Drawing.Size(172, 25);
            this.lblWhitesPlayer.TabIndex = 1;
            this.lblWhitesPlayer.Text = global::Checkers_Game.Properties.Settings.Default.WhitesPlayerName;
            this.lblWhitesPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cheatsToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.àProposToolStripMenuItem.Text = "À &Propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
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
            // pawnPlayerWhites
            // 
            this.pawnPlayerWhites.BackColor = System.Drawing.Color.White;
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
            // gameboard
            // 
            this.gameboard.AutoSize = true;
            this.gameboard.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gameboard.Location = new System.Drawing.Point(146, 149);
            this.gameboard.Margin = new System.Windows.Forms.Padding(10);
            this.gameboard.Name = "gameboard";
            this.gameboard.Size = new System.Drawing.Size(600, 600);
            this.gameboard.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(884, 763);
            this.Controls.Add(this.pawnPlayerBlacks);
            this.Controls.Add(this.pawnPlayerWhites);
            this.Controls.Add(this.lblWhitesPlayer);
            this.Controls.Add(this.lblScoreWhites);
            this.Controls.Add(this.lblScoreBlacks);
            this.Controls.Add(this.lblBlacksPlayer);
            this.Controls.Add(this.gameboard);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Checkers_Controls.Gameboard gameboard;
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
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

