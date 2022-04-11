namespace eClassroom
{
    partial class PassChange
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
            this.forgotPassClickBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passChangeNew2Tb = new System.Windows.Forms.TextBox();
            this.passChangeNewTb = new System.Windows.Forms.TextBox();
            this.passChangeCorTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginCrossBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // forgotPassClickBtn
            // 
            this.forgotPassClickBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPassClickBtn.Location = new System.Drawing.Point(203, 403);
            this.forgotPassClickBtn.Name = "forgotPassClickBtn";
            this.forgotPassClickBtn.Size = new System.Drawing.Size(130, 35);
            this.forgotPassClickBtn.TabIndex = 7;
            this.forgotPassClickBtn.Text = "Change";
            this.forgotPassClickBtn.UseVisualStyleBackColor = true;
            this.forgotPassClickBtn.Click += new System.EventHandler(this.forgotPassClickBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Re enter password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Password";
            // 
            // passChangeNew2Tb
            // 
            this.passChangeNew2Tb.Location = new System.Drawing.Point(153, 351);
            this.passChangeNew2Tb.Name = "passChangeNew2Tb";
            this.passChangeNew2Tb.Size = new System.Drawing.Size(223, 26);
            this.passChangeNew2Tb.TabIndex = 3;
            this.passChangeNew2Tb.UseSystemPasswordChar = true;
            // 
            // passChangeNewTb
            // 
            this.passChangeNewTb.Location = new System.Drawing.Point(153, 278);
            this.passChangeNewTb.Name = "passChangeNewTb";
            this.passChangeNewTb.Size = new System.Drawing.Size(223, 26);
            this.passChangeNewTb.TabIndex = 4;
            this.passChangeNewTb.UseSystemPasswordChar = true;
            // 
            // passChangeCorTb
            // 
            this.passChangeCorTb.Location = new System.Drawing.Point(153, 215);
            this.passChangeCorTb.Name = "passChangeCorTb";
            this.passChangeCorTb.Size = new System.Drawing.Size(223, 26);
            this.passChangeCorTb.TabIndex = 4;
            this.passChangeCorTb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Password";
            // 
            // loginCrossBtn
            // 
            this.loginCrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginCrossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginCrossBtn.Location = new System.Drawing.Point(462, 12);
            this.loginCrossBtn.Name = "loginCrossBtn";
            this.loginCrossBtn.Size = new System.Drawing.Size(43, 33);
            this.loginCrossBtn.TabIndex = 8;
            this.loginCrossBtn.Text = "X";
            this.loginCrossBtn.UseVisualStyleBackColor = true;
            this.loginCrossBtn.Click += new System.EventHandler(this.loginCrossBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eClassroom.Properties.Resources.change_pass;
            this.pictureBox1.Location = new System.Drawing.Point(203, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(517, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginCrossBtn);
            this.Controls.Add(this.forgotPassClickBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passChangeCorTb);
            this.Controls.Add(this.passChangeNew2Tb);
            this.Controls.Add(this.passChangeNewTb);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassChange";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forgotPassClickBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passChangeNew2Tb;
        private System.Windows.Forms.TextBox passChangeNewTb;
        private System.Windows.Forms.TextBox passChangeCorTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginCrossBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}