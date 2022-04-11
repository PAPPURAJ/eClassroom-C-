namespace eClassroom
{
    partial class Notice
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
            this.addNoticeTb = new System.Windows.Forms.TextBox();
            this.addNoticeBtn = new System.Windows.Forms.Button();
            this.noticeCrossBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNoticeTb
            // 
            this.addNoticeTb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.addNoticeTb.Location = new System.Drawing.Point(28, 45);
            this.addNoticeTb.Multiline = true;
            this.addNoticeTb.Name = "addNoticeTb";
            this.addNoticeTb.Size = new System.Drawing.Size(383, 170);
            this.addNoticeTb.TabIndex = 0;
            // 
            // addNoticeBtn
            // 
            this.addNoticeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNoticeBtn.Location = new System.Drawing.Point(153, 231);
            this.addNoticeBtn.Name = "addNoticeBtn";
            this.addNoticeBtn.Size = new System.Drawing.Size(126, 40);
            this.addNoticeBtn.TabIndex = 1;
            this.addNoticeBtn.Text = "Send";
            this.addNoticeBtn.UseVisualStyleBackColor = true;
            this.addNoticeBtn.Click += new System.EventHandler(this.addNoticeBtn_Click);
            // 
            // noticeCrossBtn
            // 
            this.noticeCrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noticeCrossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.noticeCrossBtn.Location = new System.Drawing.Point(391, 6);
            this.noticeCrossBtn.Name = "noticeCrossBtn";
            this.noticeCrossBtn.Size = new System.Drawing.Size(43, 33);
            this.noticeCrossBtn.TabIndex = 3;
            this.noticeCrossBtn.Text = "X";
            this.noticeCrossBtn.UseVisualStyleBackColor = true;
            this.noticeCrossBtn.Click += new System.EventHandler(this.noticeCrossBtn_Click);
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(446, 317);
            this.Controls.Add(this.noticeCrossBtn);
            this.Controls.Add(this.addNoticeBtn);
            this.Controls.Add(this.addNoticeTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notice";
            this.Text = "Notice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addNoticeTb;
        private System.Windows.Forms.Button addNoticeBtn;
        private System.Windows.Forms.Button noticeCrossBtn;
    }
}