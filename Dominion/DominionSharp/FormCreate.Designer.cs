namespace DominionSharp
{
    partial class FormCreate
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
            this.Label1 = new System.Windows.Forms.Label();
            this.comboNumPlayers = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(87, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Number of Players:";
            // 
            // comboNumPlayers
            // 
            this.comboNumPlayers.AutoCompleteCustomSource.AddRange(new string[] {
            "\"2\"",
            "\"3\"",
            "\"4\""});
            this.comboNumPlayers.FormattingEnabled = true;
            this.comboNumPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.comboNumPlayers.Location = new System.Drawing.Point(118, 24);
            this.comboNumPlayers.Name = "comboNumPlayers";
            this.comboNumPlayers.Size = new System.Drawing.Size(36, 21);
            this.comboNumPlayers.TabIndex = 4;
            this.comboNumPlayers.Text = "2";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(10, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(265, 123);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.comboNumPlayers);
            this.Controls.Add(this.btnStart);
            this.Name = "FormCreate";
            this.Text = "Dominion - Create Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox comboNumPlayers;
        internal System.Windows.Forms.Button btnStart;
    }
}

