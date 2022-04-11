namespace eClassroom
{
    partial class ForgotPass
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
            this.forgotPassMailTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotPassOTPTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.forgotPassClickBtn = new System.Windows.Forms.Button();
            this.forgotPassPassTb = new System.Windows.Forms.TextBox();
            this.forgotPassReEnPassTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.forgotPassSendOTPBtn = new System.Windows.Forms.Button();
            this.loginCrossBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forgotPassMailTb
            // 
            this.forgotPassMailTb.Location = new System.Drawing.Point(138, 72);
            this.forgotPassMailTb.Name = "forgotPassMailTb";
            this.forgotPassMailTb.Size = new System.Drawing.Size(182, 26);
            this.forgotPassMailTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // forgotPassOTPTb
            // 
            this.forgotPassOTPTb.Location = new System.Drawing.Point(138, 145);
            this.forgotPassOTPTb.Name = "forgotPassOTPTb";
            this.forgotPassOTPTb.Size = new System.Drawing.Size(223, 26);
            this.forgotPassOTPTb.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "OTP";
            // 
            // forgotPassClickBtn
            // 
            this.forgotPassClickBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPassClickBtn.Location = new System.Drawing.Point(190, 325);
            this.forgotPassClickBtn.Name = "forgotPassClickBtn";
            this.forgotPassClickBtn.Size = new System.Drawing.Size(130, 35);
            this.forgotPassClickBtn.TabIndex = 2;
            this.forgotPassClickBtn.Text = "Change";
            this.forgotPassClickBtn.UseVisualStyleBackColor = true;
            this.forgotPassClickBtn.Click += new System.EventHandler(this.forgotPassClickBtn_Click);
            // 
            // forgotPassPassTb
            // 
            this.forgotPassPassTb.Location = new System.Drawing.Point(138, 209);
            this.forgotPassPassTb.Name = "forgotPassPassTb";
            this.forgotPassPassTb.Size = new System.Drawing.Size(223, 26);
            this.forgotPassPassTb.TabIndex = 0;
            this.forgotPassPassTb.UseSystemPasswordChar = true;
            // 
            // forgotPassReEnPassTb
            // 
            this.forgotPassReEnPassTb.Location = new System.Drawing.Point(138, 282);
            this.forgotPassReEnPassTb.Name = "forgotPassReEnPassTb";
            this.forgotPassReEnPassTb.Size = new System.Drawing.Size(223, 26);
            this.forgotPassReEnPassTb.TabIndex = 0;
            this.forgotPassReEnPassTb.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Re enter password";
            // 
            // forgotPassSendOTPBtn
            // 
            this.forgotPassSendOTPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPassSendOTPBtn.Location = new System.Drawing.Point(326, 70);
            this.forgotPassSendOTPBtn.Name = "forgotPassSendOTPBtn";
            this.forgotPassSendOTPBtn.Size = new System.Drawing.Size(35, 30);
            this.forgotPassSendOTPBtn.TabIndex = 2;
            this.forgotPassSendOTPBtn.Text = ">";
            this.forgotPassSendOTPBtn.UseVisualStyleBackColor = true;
            this.forgotPassSendOTPBtn.Click += new System.EventHandler(this.forgotPassSendOTPBtn_Click);
            // 
            // loginCrossBtn
            // 
            this.loginCrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginCrossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginCrossBtn.Location = new System.Drawing.Point(422, 12);
            this.loginCrossBtn.Name = "loginCrossBtn";
            this.loginCrossBtn.Size = new System.Drawing.Size(43, 33);
            this.loginCrossBtn.TabIndex = 5;
            this.loginCrossBtn.Text = "X";
            this.loginCrossBtn.UseVisualStyleBackColor = true;
            this.loginCrossBtn.Click += new System.EventHandler(this.loginCrossBtn_Click);
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(477, 439);
            this.Controls.Add(this.loginCrossBtn);
            this.Controls.Add(this.forgotPassSendOTPBtn);
            this.Controls.Add(this.forgotPassClickBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forgotPassReEnPassTb);
            this.Controls.Add(this.forgotPassPassTb);
            this.Controls.Add(this.forgotPassOTPTb);
            this.Controls.Add(this.forgotPassMailTb);
            this.ForeColor = System.Drawing.Color.Aquamarine;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox forgotPassMailTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox forgotPassOTPTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button forgotPassClickBtn;
        private System.Windows.Forms.TextBox forgotPassPassTb;
        private System.Windows.Forms.TextBox forgotPassReEnPassTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button forgotPassSendOTPBtn;
        private System.Windows.Forms.Button loginCrossBtn;
    }
}