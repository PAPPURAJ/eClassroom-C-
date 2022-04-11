namespace eClassroom
{
    partial class CreateAnAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAnAccountForm));
            this.createAccLoginBtn = new System.Windows.Forms.Button();
            this.createAccPassLb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createAccMailLb = new System.Windows.Forms.TextBox();
            this.createAccountClick = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccPass2Lb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createAccNameLb = new System.Windows.Forms.TextBox();
            this.createAccUserRadio = new System.Windows.Forms.RadioButton();
            this.createAccAdminRadio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.createAccClassPassLb = new System.Windows.Forms.TextBox();
            this.createAccClassIDTb = new System.Windows.Forms.TextBox();
            this.CreateAccCrossBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createAccLoginBtn
            // 
            this.createAccLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccLoginBtn.Location = new System.Drawing.Point(350, 500);
            this.createAccLoginBtn.Name = "createAccLoginBtn";
            this.createAccLoginBtn.Size = new System.Drawing.Size(220, 57);
            this.createAccLoginBtn.TabIndex = 8;
            this.createAccLoginBtn.Text = "Sign up";
            this.createAccLoginBtn.UseVisualStyleBackColor = true;
            this.createAccLoginBtn.Click += new System.EventHandler(this.createAccLoginBtn_Click);
            // 
            // createAccPassLb
            // 
            this.createAccPassLb.Location = new System.Drawing.Point(140, 344);
            this.createAccPassLb.Name = "createAccPassLb";
            this.createAccPassLb.Size = new System.Drawing.Size(199, 26);
            this.createAccPassLb.TabIndex = 6;
            this.createAccPassLb.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // createAccMailLb
            // 
            this.createAccMailLb.Location = new System.Drawing.Point(140, 262);
            this.createAccMailLb.Name = "createAccMailLb";
            this.createAccMailLb.Size = new System.Drawing.Size(199, 26);
            this.createAccMailLb.TabIndex = 7;
            // 
            // createAccountClick
            // 
            this.createAccountClick.AutoSize = true;
            this.createAccountClick.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createAccountClick.Location = new System.Drawing.Point(588, 585);
            this.createAccountClick.Name = "createAccountClick";
            this.createAccountClick.Size = new System.Drawing.Size(192, 20);
            this.createAccountClick.TabIndex = 4;
            this.createAccountClick.Text = "Already have an account?";
            this.createAccountClick.Click += new System.EventHandler(this.createAccountClick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // createAccPass2Lb
            // 
            this.createAccPass2Lb.Location = new System.Drawing.Point(140, 420);
            this.createAccPass2Lb.Name = "createAccPass2Lb";
            this.createAccPass2Lb.Size = new System.Drawing.Size(199, 26);
            this.createAccPass2Lb.TabIndex = 10;
            this.createAccPass2Lb.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Re enter Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // createAccNameLb
            // 
            this.createAccNameLb.Location = new System.Drawing.Point(140, 188);
            this.createAccNameLb.Name = "createAccNameLb";
            this.createAccNameLb.Size = new System.Drawing.Size(199, 26);
            this.createAccNameLb.TabIndex = 7;
            // 
            // createAccUserRadio
            // 
            this.createAccUserRadio.AutoSize = true;
            this.createAccUserRadio.Location = new System.Drawing.Point(626, 247);
            this.createAccUserRadio.Name = "createAccUserRadio";
            this.createAccUserRadio.Size = new System.Drawing.Size(68, 24);
            this.createAccUserRadio.TabIndex = 11;
            this.createAccUserRadio.TabStop = true;
            this.createAccUserRadio.Text = "User";
            this.createAccUserRadio.UseVisualStyleBackColor = true;
            // 
            // createAccAdminRadio
            // 
            this.createAccAdminRadio.AutoSize = true;
            this.createAccAdminRadio.Location = new System.Drawing.Point(530, 247);
            this.createAccAdminRadio.Name = "createAccAdminRadio";
            this.createAccAdminRadio.Size = new System.Drawing.Size(79, 24);
            this.createAccAdminRadio.TabIndex = 11;
            this.createAccAdminRadio.TabStop = true;
            this.createAccAdminRadio.Text = "Admin";
            this.createAccAdminRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "User type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Class pass";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Class ID";
            // 
            // createAccClassPassLb
            // 
            this.createAccClassPassLb.Location = new System.Drawing.Point(522, 423);
            this.createAccClassPassLb.Name = "createAccClassPassLb";
            this.createAccClassPassLb.Size = new System.Drawing.Size(199, 26);
            this.createAccClassPassLb.TabIndex = 7;
            // 
            // createAccClassIDTb
            // 
            this.createAccClassIDTb.Location = new System.Drawing.Point(522, 349);
            this.createAccClassIDTb.Name = "createAccClassIDTb";
            this.createAccClassIDTb.Size = new System.Drawing.Size(199, 26);
            this.createAccClassIDTb.TabIndex = 7;
            // 
            // CreateAccCrossBtn
            // 
            this.CreateAccCrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccCrossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateAccCrossBtn.Location = new System.Drawing.Point(837, 12);
            this.CreateAccCrossBtn.Name = "CreateAccCrossBtn";
            this.CreateAccCrossBtn.Size = new System.Drawing.Size(43, 33);
            this.CreateAccCrossBtn.TabIndex = 12;
            this.CreateAccCrossBtn.Text = "X";
            this.CreateAccCrossBtn.UseVisualStyleBackColor = true;
            this.CreateAccCrossBtn.Click += new System.EventHandler(this.CreateAccCrossBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // CreateAnAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(892, 636);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CreateAccCrossBtn);
            this.Controls.Add(this.createAccAdminRadio);
            this.Controls.Add(this.createAccUserRadio);
            this.Controls.Add(this.createAccPass2Lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createAccLoginBtn);
            this.Controls.Add(this.createAccPassLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createAccClassIDTb);
            this.Controls.Add(this.createAccNameLb);
            this.Controls.Add(this.createAccClassPassLb);
            this.Controls.Add(this.createAccMailLb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createAccountClick);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAnAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAnAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAccLoginBtn;
        private System.Windows.Forms.TextBox createAccPassLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox createAccMailLb;
        private System.Windows.Forms.Label createAccountClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox createAccPass2Lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox createAccNameLb;
        private System.Windows.Forms.RadioButton createAccUserRadio;
        private System.Windows.Forms.RadioButton createAccAdminRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox createAccClassPassLb;
        private System.Windows.Forms.TextBox createAccClassIDTb;
        private System.Windows.Forms.Button CreateAccCrossBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}