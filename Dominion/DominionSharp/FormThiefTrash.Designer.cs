namespace DominionSharp
{
    partial class FormThiefTrash
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
            this.btn_trash1 = new System.Windows.Forms.Button();
            this.lbl_instruct = new System.Windows.Forms.Label();
            this.btn_trash2 = new System.Windows.Forms.Button();
            this.btn_none = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_trash1
            // 
            this.btn_trash1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trash1.Location = new System.Drawing.Point(16, 60);
            this.btn_trash1.Name = "btn_trash1";
            this.btn_trash1.Size = new System.Drawing.Size(253, 31);
            this.btn_trash1.TabIndex = 0;
            this.btn_trash1.Text = "Trash 1";
            this.btn_trash1.UseVisualStyleBackColor = true;
            this.btn_trash1.Click += new System.EventHandler(this.btn_trash1_Click);
            // 
            // lbl_instruct
            // 
            this.lbl_instruct.AutoSize = true;
            this.lbl_instruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruct.Location = new System.Drawing.Point(12, 9);
            this.lbl_instruct.Name = "lbl_instruct";
            this.lbl_instruct.Size = new System.Drawing.Size(257, 48);
            this.lbl_instruct.TabIndex = 1;
            this.lbl_instruct.Text = "Which revealed treasure card\r\nwould you like to trash?";
            // 
            // btn_trash2
            // 
            this.btn_trash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trash2.Location = new System.Drawing.Point(16, 97);
            this.btn_trash2.Name = "btn_trash2";
            this.btn_trash2.Size = new System.Drawing.Size(253, 31);
            this.btn_trash2.TabIndex = 2;
            this.btn_trash2.Text = "Trash 2";
            this.btn_trash2.UseVisualStyleBackColor = true;
            this.btn_trash2.Click += new System.EventHandler(this.btn_trash2_Click);
            // 
            // btn_none
            // 
            this.btn_none.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_none.Location = new System.Drawing.Point(16, 134);
            this.btn_none.Name = "btn_none";
            this.btn_none.Size = new System.Drawing.Size(253, 31);
            this.btn_none.TabIndex = 3;
            this.btn_none.Text = "None";
            this.btn_none.UseVisualStyleBackColor = true;
            this.btn_none.Click += new System.EventHandler(this.btn_none_Click);
            // 
            // TheifTrashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 176);
            this.Controls.Add(this.btn_none);
            this.Controls.Add(this.btn_trash2);
            this.Controls.Add(this.lbl_instruct);
            this.Controls.Add(this.btn_trash1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TheifTrashForm";
            this.Text = "Target: Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_trash1;
        private System.Windows.Forms.Label lbl_instruct;
        private System.Windows.Forms.Button btn_trash2;
        private System.Windows.Forms.Button btn_none;
    }
}