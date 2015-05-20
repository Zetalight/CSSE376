namespace DominionSharp
{
    partial class FormCellar
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
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.ckls_hand = new System.Windows.Forms.CheckedListBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instructions.Location = new System.Drawing.Point(26, 9);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(325, 40);
            this.lbl_instructions.TabIndex = 0;
            this.lbl_instructions.Text = "Discard any number of cards from your hand,\r\n+1 Card per card discarded.";
            // 
            // ckls_hand
            // 
            this.ckls_hand.FormattingEnabled = true;
            this.ckls_hand.Location = new System.Drawing.Point(9, 56);
            this.ckls_hand.Name = "ckls_hand";
            this.ckls_hand.Size = new System.Drawing.Size(358, 394);
            this.ckls_hand.TabIndex = 1;
            this.ckls_hand.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ckls_hand_ItemCheck);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(12, 456);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(355, 71);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // FormCellar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 534);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.ckls_hand);
            this.Controls.Add(this.lbl_instructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCellar";
            this.Text = "Cellar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_instructions;
        private System.Windows.Forms.CheckedListBox ckls_hand;
        private System.Windows.Forms.Button btn_confirm;
    }
}