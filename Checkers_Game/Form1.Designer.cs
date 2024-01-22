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
			this.button1 = new System.Windows.Forms.Button();
			this.gameboard1 = new Checkers_Controls.Gameboard();
			this.pawnControl1 = new Checkers_Controls.PawnControl();
			this.pawnControl2 = new Checkers_Controls.PawnControl();
			this.SuspendLayout();
			// 
			// lblBlacksPlayer
			// 
			this.lblBlacksPlayer.AutoSize = true;
			this.lblBlacksPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBlacksPlayer.Location = new System.Drawing.Point(45, 59);
			this.lblBlacksPlayer.Name = "lblBlacksPlayer";
			this.lblBlacksPlayer.Size = new System.Drawing.Size(101, 25);
			this.lblBlacksPlayer.TabIndex = 1;
			this.lblBlacksPlayer.Text = "BLACKS";
			// 
			// lblWhitesPlayer
			// 
			this.lblWhitesPlayer.AutoSize = true;
			this.lblWhitesPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWhitesPlayer.Location = new System.Drawing.Point(744, 59);
			this.lblWhitesPlayer.Name = "lblWhitesPlayer";
			this.lblWhitesPlayer.Size = new System.Drawing.Size(99, 25);
			this.lblWhitesPlayer.TabIndex = 1;
			this.lblWhitesPlayer.Text = "WHITES";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(195, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 34);
			this.button1.TabIndex = 2;
			this.button1.Text = "Change Player";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gameboard1
			// 
			this.gameboard1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.gameboard1.Location = new System.Drawing.Point(195, 59);
			this.gameboard1.Margin = new System.Windows.Forms.Padding(10);
			this.gameboard1.Name = "gameboard1";
			this.gameboard1.Size = new System.Drawing.Size(500, 500);
			this.gameboard1.TabIndex = 0;
			// 
			// pawnControl1
			// 
			this.pawnControl1.BackColor = System.Drawing.Color.Black;
			this.pawnControl1.Color = Checkers_Library.Enumerations.GameColor.Black;
			this.pawnControl1.Location = new System.Drawing.Point(71, 87);
			this.pawnControl1.MaximumSize = new System.Drawing.Size(50, 50);
			this.pawnControl1.MinimumSize = new System.Drawing.Size(50, 50);
			this.pawnControl1.Name = "pawnControl1";
			this.pawnControl1.Size = new System.Drawing.Size(50, 50);
			this.pawnControl1.TabIndex = 3;
			// 
			// pawnControl2
			// 
			this.pawnControl2.BackColor = System.Drawing.Color.White;
			this.pawnControl2.Color = Checkers_Library.Enumerations.GameColor.White;
			this.pawnControl2.Location = new System.Drawing.Point(768, 87);
			this.pawnControl2.MaximumSize = new System.Drawing.Size(50, 50);
			this.pawnControl2.MinimumSize = new System.Drawing.Size(50, 50);
			this.pawnControl2.Name = "pawnControl2";
			this.pawnControl2.Size = new System.Drawing.Size(50, 50);
			this.pawnControl2.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SaddleBrown;
			this.ClientSize = new System.Drawing.Size(884, 735);
			this.Controls.Add(this.pawnControl2);
			this.Controls.Add(this.pawnControl1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblWhitesPlayer);
			this.Controls.Add(this.lblBlacksPlayer);
			this.Controls.Add(this.gameboard1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Checkers_Controls.Gameboard gameboard1;
        private System.Windows.Forms.Label lblBlacksPlayer;
        private System.Windows.Forms.Label lblWhitesPlayer;
        private System.Windows.Forms.Button button1;
        private Checkers_Controls.PawnControl pawnControl1;
        private Checkers_Controls.PawnControl pawnControl2;
    }
}

