namespace DominionSharp
{
    partial class FormGame
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
            this.tabsPlayers = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.btnHideRevealHand = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblBuys = new System.Windows.Forms.Label();
            this.lblActions = new System.Windows.Forms.Label();
            this.btnNextPhase = new System.Windows.Forms.Button();
            this.lbl_phase = new System.Windows.Forms.Label();
            this.tabPiles = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabsPlayers.SuspendLayout();
            this.tabPiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsPlayers
            // 
            this.tabsPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsPlayers.Controls.Add(this.TabPage1);
            this.tabsPlayers.Controls.Add(this.TabPage2);
            this.tabsPlayers.Location = new System.Drawing.Point(12, 314);
            this.tabsPlayers.Name = "tabsPlayers";
            this.tabsPlayers.SelectedIndex = 0;
            this.tabsPlayers.Size = new System.Drawing.Size(760, 276);
            this.tabsPlayers.TabIndex = 6;
            // 
            // TabPage1
            // 
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabPage1.Size = new System.Drawing.Size(752, 250);
            this.TabPage1.TabIndex = 2;
            this.TabPage1.Text = "*Player 1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabPage2.Size = new System.Drawing.Size(752, 250);
            this.TabPage2.TabIndex = 3;
            this.TabPage2.Text = "Player 2";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHideRevealHand
            // 
            this.btnHideRevealHand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHideRevealHand.Location = new System.Drawing.Point(634, 285);
            this.btnHideRevealHand.Name = "btnHideRevealHand";
            this.btnHideRevealHand.Size = new System.Drawing.Size(137, 23);
            this.btnHideRevealHand.TabIndex = 7;
            this.btnHideRevealHand.Text = "Hide/Reveal Hand";
            this.btnHideRevealHand.UseVisualStyleBackColor = true;
            this.btnHideRevealHand.Click += new System.EventHandler(this.btnHideRevealHand_Click);
            // 
            // lblCoins
            // 
            this.lblCoins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoins.AutoSize = true;
            this.lblCoins.Location = new System.Drawing.Point(525, 290);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(45, 13);
            this.lblCoins.TabIndex = 12;
            this.lblCoins.Text = "Coins: 0";
            // 
            // lblBuys
            // 
            this.lblBuys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuys.AutoSize = true;
            this.lblBuys.Location = new System.Drawing.Point(419, 290);
            this.lblBuys.Name = "lblBuys";
            this.lblBuys.Size = new System.Drawing.Size(42, 13);
            this.lblBuys.TabIndex = 11;
            this.lblBuys.Text = "Buys: 1";
            // 
            // lblActions
            // 
            this.lblActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(301, 290);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(54, 13);
            this.lblActions.TabIndex = 10;
            this.lblActions.Text = "Actions: 1";
            // 
            // btnNextPhase
            // 
            this.btnNextPhase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPhase.Location = new System.Drawing.Point(16, 285);
            this.btnNextPhase.Name = "btnNextPhase";
            this.btnNextPhase.Size = new System.Drawing.Size(96, 23);
            this.btnNextPhase.TabIndex = 9;
            this.btnNextPhase.Text = "Next Phase";
            this.btnNextPhase.UseVisualStyleBackColor = true;
            this.btnNextPhase.Click += new System.EventHandler(this.btnNextPhase_Click);
            // 
            // lbl_phase
            // 
            this.lbl_phase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_phase.AutoSize = true;
            this.lbl_phase.Location = new System.Drawing.Point(176, 290);
            this.lbl_phase.Name = "lbl_phase";
            this.lbl_phase.Size = new System.Drawing.Size(73, 13);
            this.lbl_phase.TabIndex = 13;
            this.lbl_phase.Text = "Phase: Action";
            // 
            // tabPiles
            // 
            this.tabPiles.Controls.Add(this.tabPage3);
            this.tabPiles.Controls.Add(this.tabPage4);
            this.tabPiles.Location = new System.Drawing.Point(16, 10);
            this.tabPiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPiles.Name = "tabPiles";
            this.tabPiles.SelectedIndex = 0;
            this.tabPiles.Size = new System.Drawing.Size(753, 269);
            this.tabPiles.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(745, 243);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(745, 243);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 602);
            this.Controls.Add(this.lbl_phase);
            this.Controls.Add(this.tabsPlayers);
            this.Controls.Add(this.btnHideRevealHand);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.lblBuys);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.btnNextPhase);
            this.Controls.Add(this.tabPiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGame";
            this.Text = "Dominion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.tabsPlayers.ResumeLayout(false);
            this.tabPiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TabControl tabsPlayers;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button btnHideRevealHand;
        internal System.Windows.Forms.Label lblCoins;
        internal System.Windows.Forms.Label lblBuys;
        internal System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Button btnNextPhase;
        internal System.Windows.Forms.Label lbl_phase;
        private System.Windows.Forms.TabControl tabPiles;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}