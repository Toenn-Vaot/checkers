namespace Checkers_Game
{
    partial class StartGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBlacksPlayer = new System.Windows.Forms.Label();
            this.lblWhitesPlayer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtWhitesPlayerName = new System.Windows.Forms.TextBox();
            this.txtBlacksPlayerName = new System.Windows.Forms.TextBox();
            this.pawnPlayerBlacks = new Checkers_Controls.PawnControl();
            this.pawnPlayerWhites = new Checkers_Controls.PawnControl();
            this.rdRuleInternational = new System.Windows.Forms.RadioButton();
            this.rdRuleEnglish = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBlacksPlayer
            // 
            this.lblBlacksPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlacksPlayer.Location = new System.Drawing.Point(56, 65);
            this.lblBlacksPlayer.Name = "lblBlacksPlayer";
            this.lblBlacksPlayer.Size = new System.Drawing.Size(176, 25);
            this.lblBlacksPlayer.TabIndex = 0;
            this.lblBlacksPlayer.Text = "BLACKS";
            this.lblBlacksPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhitesPlayer
            // 
            this.lblWhitesPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWhitesPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhitesPlayer.Location = new System.Drawing.Point(348, 65);
            this.lblWhitesPlayer.Name = "lblWhitesPlayer";
            this.lblWhitesPlayer.Size = new System.Drawing.Size(172, 25);
            this.lblWhitesPlayer.TabIndex = 0;
            this.lblWhitesPlayer.Text = "WHITES";
            this.lblWhitesPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(157, 195);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(256, 67);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtWhitesPlayerName
            // 
            this.txtWhitesPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWhitesPlayerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Checkers_Game.Properties.Settings.Default, "WhitesPlayerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWhitesPlayerName.Location = new System.Drawing.Point(353, 99);
            this.txtWhitesPlayerName.Name = "txtWhitesPlayerName";
            this.txtWhitesPlayerName.Size = new System.Drawing.Size(157, 20);
            this.txtWhitesPlayerName.TabIndex = 2;
            this.txtWhitesPlayerName.Text = global::Checkers_Game.Properties.Settings.Default.WhitesPlayerName;
            this.txtWhitesPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBlacksPlayerName
            // 
            this.txtBlacksPlayerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Checkers_Game.Properties.Settings.Default, "BlacksPlayerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBlacksPlayerName.Location = new System.Drawing.Point(66, 99);
            this.txtBlacksPlayerName.Name = "txtBlacksPlayerName";
            this.txtBlacksPlayerName.Size = new System.Drawing.Size(157, 20);
            this.txtBlacksPlayerName.TabIndex = 1;
            this.txtBlacksPlayerName.Text = global::Checkers_Game.Properties.Settings.Default.BlacksPlayerName;
            this.txtBlacksPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pawnPlayerBlacks
            // 
            this.pawnPlayerBlacks.BackColor = System.Drawing.Color.Black;
            this.pawnPlayerBlacks.Color = Checkers_Library.Enumerations.GameColor.Black;
            this.pawnPlayerBlacks.HasGloups = false;
            this.pawnPlayerBlacks.IsGloupsed = false;
            this.pawnPlayerBlacks.IsQueen = false;
            this.pawnPlayerBlacks.Location = new System.Drawing.Point(119, 12);
            this.pawnPlayerBlacks.MaximumSize = new System.Drawing.Size(50, 50);
            this.pawnPlayerBlacks.MinimumSize = new System.Drawing.Size(50, 50);
            this.pawnPlayerBlacks.Name = "pawnPlayerBlacks";
            this.pawnPlayerBlacks.Size = new System.Drawing.Size(50, 50);
            this.pawnPlayerBlacks.TabIndex = 0;
            // 
            // pawnPlayerWhites
            // 
            this.pawnPlayerWhites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pawnPlayerWhites.BackColor = System.Drawing.Color.White;
            this.pawnPlayerWhites.Color = Checkers_Library.Enumerations.GameColor.White;
            this.pawnPlayerWhites.HasGloups = false;
            this.pawnPlayerWhites.IsGloupsed = false;
            this.pawnPlayerWhites.IsQueen = false;
            this.pawnPlayerWhites.Location = new System.Drawing.Point(409, 12);
            this.pawnPlayerWhites.MaximumSize = new System.Drawing.Size(50, 50);
            this.pawnPlayerWhites.MinimumSize = new System.Drawing.Size(50, 50);
            this.pawnPlayerWhites.Name = "pawnPlayerWhites";
            this.pawnPlayerWhites.Size = new System.Drawing.Size(50, 50);
            this.pawnPlayerWhites.TabIndex = 0;
            // 
            // rdRuleInternational
            // 
            this.rdRuleInternational.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdRuleInternational.AutoSize = true;
            this.rdRuleInternational.Checked = true;
            this.rdRuleInternational.Location = new System.Drawing.Point(12, 161);
            this.rdRuleInternational.Name = "rdRuleInternational";
            this.rdRuleInternational.Size = new System.Drawing.Size(83, 17);
            this.rdRuleInternational.TabIndex = 4;
            this.rdRuleInternational.TabStop = true;
            this.rdRuleInternational.Tag = "FR";
            this.rdRuleInternational.Text = "International";
            this.rdRuleInternational.UseVisualStyleBackColor = true;
            this.rdRuleInternational.CheckedChanged += new System.EventHandler(this.rdRule_CheckedChanged);
            // 
            // rdRuleEnglish
            // 
            this.rdRuleEnglish.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdRuleEnglish.AutoSize = true;
            this.rdRuleEnglish.Location = new System.Drawing.Point(101, 161);
            this.rdRuleEnglish.Name = "rdRuleEnglish";
            this.rdRuleEnglish.Size = new System.Drawing.Size(59, 17);
            this.rdRuleEnglish.TabIndex = 4;
            this.rdRuleEnglish.Tag = "UK";
            this.rdRuleEnglish.Text = "English";
            this.rdRuleEnglish.UseVisualStyleBackColor = true;
            this.rdRuleEnglish.CheckedChanged += new System.EventHandler(this.rdRule_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(166, 161);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Tag = "ES";
            this.radioButton2.Text = "Spanish";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rdRule_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(235, 161);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Tag = "DE";
            this.radioButton3.Text = "German";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rdRule_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(303, 161);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Tag = "IT";
            this.radioButton4.Text = "Italian";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.rdRule_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(362, 161);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(54, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Tag = "NL";
            this.radioButton5.Text = "Dutch";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.rdRule_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(422, 161);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(63, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.Tag = "RU";
            this.radioButton6.Text = "Russian";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.rdRule_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(491, 161);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(70, 17);
            this.radioButton7.TabIndex = 4;
            this.radioButton7.Tag = "CA";
            this.radioButton7.Text = "Canadian";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.rdRule_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rules";
            // 
            // StartGameForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rdRuleEnglish);
            this.Controls.Add(this.rdRuleInternational);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblWhitesPlayer);
            this.Controls.Add(this.lblBlacksPlayer);
            this.Controls.Add(this.txtWhitesPlayerName);
            this.Controls.Add(this.txtBlacksPlayerName);
            this.Controls.Add(this.pawnPlayerBlacks);
            this.Controls.Add(this.pawnPlayerWhites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartGameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New game";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StartGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Checkers_Controls.PawnControl pawnPlayerWhites;
        private Checkers_Controls.PawnControl pawnPlayerBlacks;
        private System.Windows.Forms.TextBox txtBlacksPlayerName;
        private System.Windows.Forms.TextBox txtWhitesPlayerName;
        private System.Windows.Forms.Label lblBlacksPlayer;
        private System.Windows.Forms.Label lblWhitesPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rdRuleInternational;
        private System.Windows.Forms.RadioButton rdRuleEnglish;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label label1;
    }
}