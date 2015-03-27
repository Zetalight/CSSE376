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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.tabsPlayers = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.tabsPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Location = new System.Drawing.Point(16, 15);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(800, 329);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Supply";
            // 
            // Button2
            // 
            this.Button2.BackgroundImage = global::DominionSharp.Properties.Resources.chapel;
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button2.Location = new System.Drawing.Point(8, 23);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(227, 298);
            this.Button2.TabIndex = 0;
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // tabsPlayers
            // 
            this.tabsPlayers.Controls.Add(this.TabPage1);
            this.tabsPlayers.Controls.Add(this.TabPage2);
            this.tabsPlayers.Location = new System.Drawing.Point(16, 386);
            this.tabsPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabsPlayers.Name = "tabsPlayers";
            this.tabsPlayers.SelectedIndex = 0;
            this.tabsPlayers.Size = new System.Drawing.Size(800, 340);
            this.tabsPlayers.TabIndex = 6;
            // 
            // TabPage1
            // 
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPage1.Size = new System.Drawing.Size(792, 311);
            this.TabPage1.TabIndex = 2;
            this.TabPage1.Text = "*Player 1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            this.TabPage2.Location = new System.Drawing.Point(4, 25);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPage2.Size = new System.Drawing.Size(792, 311);
            this.TabPage2.TabIndex = 3;
            this.TabPage2.Text = "Player 2";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(663, 351);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(149, 28);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Hide/Reveal Hand";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(525, 357);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 17);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Coins: 0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(392, 357);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 17);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Buys: 1";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(243, 357);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 17);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Actions: 1";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(16, 351);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(149, 28);
            this.Button3.TabIndex = 9;
            this.Button3.Text = "Start/End Turn";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 741);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.tabsPlayers);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.GroupBox1.ResumeLayout(false);
            this.tabsPlayers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TabControl tabsPlayers;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button3;
    }
}