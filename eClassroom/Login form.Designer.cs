namespace eClassroom
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.label1 = new System.Windows.Forms.Label();
            this.loginMailTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPassTb = new System.Windows.Forms.TextBox();
            this.createAccountClick = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginCrossBtn = new System.Windows.Forms.Button();
            this.forgotPassLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // loginMailTb
            // 
            this.loginMailTb.Location = new System.Drawing.Point(307, 226);
            this.loginMailTb.Name = "loginMailTb";
            this.loginMailTb.Size = new System.Drawing.Size(199, 26);
            this.loginMailTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // loginPassTb
            // 
            this.loginPassTb.Location = new System.Drawing.Point(307, 312);
            this.loginPassTb.Name = "loginPassTb";
            this.loginPassTb.Size = new System.Drawing.Size(199, 26);
            this.loginPassTb.TabIndex = 1;
            this.loginPassTb.UseSystemPasswordChar = true;
            // 
            // createAccountClick
            // 
            this.createAccountClick.AutoSize = true;
            this.createAccountClick.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createAccountClick.Location = new System.Drawing.Point(476, 420);
            this.createAccountClick.Name = "createAccountClick";
            this.createAccountClick.Size = new System.Drawing.Size(140, 20);
            this.createAccountClick.TabIndex = 0;
            this.createAccountClick.Text = "Create an account";
            this.createAccountClick.Click += new System.EventHandler(this.createAccountClick_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(354, 373);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(102, 32);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loginCrossBtn
            // 
            this.loginCrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginCrossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginCrossBtn.Location = new System.Drawing.Point(728, 12);
            this.loginCrossBtn.Name = "loginCrossBtn";
            this.loginCrossBtn.Size = new System.Drawing.Size(43, 33);
            this.loginCrossBtn.TabIndex = 4;
            this.loginCrossBtn.Text = "X";
            this.loginCrossBtn.UseVisualStyleBackColor = true;
            this.loginCrossBtn.Click += new System.EventHandler(this.loginCrossBtn_Click);
            // 
            // forgotPassLb
            // 
            this.forgotPassLb.AutoSize = true;
            this.forgotPassLb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.forgotPassLb.Location = new System.Drawing.Point(197, 420);
            this.forgotPassLb.Name = "forgotPassLb";
            this.forgotPassLb.Size = new System.Drawing.Size(128, 20);
            this.forgotPassLb.TabIndex = 5;
            this.forgotPassLb.Text = "Forgot password";
            this.forgotPassLb.Click += new System.EventHandler(this.forgotPassLb_Click);
            // 
            // Login_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(783, 482);
            this.Controls.Add(this.forgotPassLb);
            this.Controls.Add(this.loginCrossBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginPassTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginMailTb);
            this.Controls.Add(this.createAccountClick);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginMailTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginPassTb;
        private System.Windows.Forms.Label createAccountClick;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginCrossBtn;
        private System.Windows.Forms.Label forgotPassLb;
    }
}