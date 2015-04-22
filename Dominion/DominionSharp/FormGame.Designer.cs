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
            this.groupBoxSupply = new System.Windows.Forms.GroupBox();
            this.tabsPlayers = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.btnHideRevealHand = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblBuys = new System.Windows.Forms.Label();
            this.lblActions = new System.Windows.Forms.Label();
            this.btnStartEndTurn = new System.Windows.Forms.Button();
            this.tabsPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSupply
            // 
            this.groupBoxSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSupply.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSupply.Name = "groupBoxSupply";
            this.groupBoxSupply.Size = new System.Drawing.Size(760, 267);
            this.groupBoxSupply.TabIndex = 8;
            this.groupBoxSupply.TabStop = false;
            this.groupBoxSupply.Text = "Supply";
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
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(752, 250);
            this.TabPage1.TabIndex = 2;
            this.TabPage1.Text = "*Player 1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
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
            // 
            // lblCoins
            // 
            this.lblCoins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoins.AutoSize = true;
            this.lblCoins.Location = new System.Drawing.Point(503, 290);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(45, 13);
            this.lblCoins.TabIndex = 12;
            this.lblCoins.Text = "Coins: 0";
            // 
            // lblBuys
            // 
            this.lblBuys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuys.AutoSize = true;
            this.lblBuys.Location = new System.Drawing.Point(375, 290);
            this.lblBuys.Name = "lblBuys";
            this.lblBuys.Size = new System.Drawing.Size(42, 13);
            this.lblBuys.TabIndex = 11;
            this.lblBuys.Text = "Buys: 1";
            // 
            // lblActions
            // 
            this.lblActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(235, 290);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(54, 13);
            this.lblActions.TabIndex = 10;
            this.lblActions.Text = "Actions: 1";
            // 
            // btnStartEndTurn
            // 
            this.btnStartEndTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartEndTurn.Location = new System.Drawing.Point(12, 285);
            this.btnStartEndTurn.Name = "btnStartEndTurn";
            this.btnStartEndTurn.Size = new System.Drawing.Size(137, 23);
            this.btnStartEndTurn.TabIndex = 9;
            this.btnStartEndTurn.Text = "Start/End Turn";
            this.btnStartEndTurn.UseVisualStyleBackColor = true;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 602);
            this.Controls.Add(this.groupBoxSupply);
            this.Controls.Add(this.tabsPlayers);
            this.Controls.Add(this.btnHideRevealHand);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.lblBuys);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.btnStartEndTurn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.tabsPlayers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBoxSupply;
        internal System.Windows.Forms.TabControl tabsPlayers;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button btnHideRevealHand;
        internal System.Windows.Forms.Label lblCoins;
        internal System.Windows.Forms.Label lblBuys;
        internal System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Button btnStartEndTurn;
    }
}