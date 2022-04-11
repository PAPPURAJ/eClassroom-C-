namespace eClassroom
{
    partial class AddRoutine
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
            this.addRoutineClassNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addRoutineSubmitBtn = new System.Windows.Forms.Button();
            this.addRoutineTeacherNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addRoutineClassLinkTb = new System.Windows.Forms.TextBox();
            this.addRoutineClassEndTb = new System.Windows.Forms.TextBox();
            this.addRoutineClassStartTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginCrossBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addRoutineClassNameTb
            // 
            this.addRoutineClassNameTb.Location = new System.Drawing.Point(268, 245);
            this.addRoutineClassNameTb.Name = "addRoutineClassNameTb";
            this.addRoutineClassNameTb.Size = new System.Drawing.Size(275, 26);
            this.addRoutineClassNameTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Name";
            // 
            // addRoutineSubmitBtn
            // 
            this.addRoutineSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoutineSubmitBtn.Location = new System.Drawing.Point(291, 430);
            this.addRoutineSubmitBtn.Name = "addRoutineSubmitBtn";
            this.addRoutineSubmitBtn.Size = new System.Drawing.Size(213, 40);
            this.addRoutineSubmitBtn.TabIndex = 2;
            this.addRoutineSubmitBtn.Text = "Submit";
            this.addRoutineSubmitBtn.UseVisualStyleBackColor = true;
            this.addRoutineSubmitBtn.Click += new System.EventHandler(this.addRoutineSubmitBtn_Click);
            // 
            // addRoutineTeacherNameTb
            // 
            this.addRoutineTeacherNameTb.Location = new System.Drawing.Point(268, 277);
            this.addRoutineTeacherNameTb.Name = "addRoutineTeacherNameTb";
            this.addRoutineTeacherNameTb.Size = new System.Drawing.Size(275, 26);
            this.addRoutineTeacherNameTb.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start time";
            // 
            // addRoutineClassLinkTb
            // 
            this.addRoutineClassLinkTb.Location = new System.Drawing.Point(268, 375);
            this.addRoutineClassLinkTb.Name = "addRoutineClassLinkTb";
            this.addRoutineClassLinkTb.Size = new System.Drawing.Size(275, 26);
            this.addRoutineClassLinkTb.TabIndex = 3;
            // 
            // addRoutineClassEndTb
            // 
            this.addRoutineClassEndTb.Location = new System.Drawing.Point(268, 341);
            this.addRoutineClassEndTb.Name = "addRoutineClassEndTb";
            this.addRoutineClassEndTb.Size = new System.Drawing.Size(275, 26);
            this.addRoutineClassEndTb.TabIndex = 4;
            // 
            // addRoutineClassStartTb
            // 
            this.addRoutineClassStartTb.Location = new System.Drawing.Point(268, 309);
            this.addRoutineClassStartTb.Name = "addRoutineClassStartTb";
            this.addRoutineClassStartTb.Size = new System.Drawing.Size(275, 26);
            this.addRoutineClassStartTb.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eClassroom.Properties.Resources.routine_img;
            this.pictureBox1.Location = new System.Drawing.Point(291, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // loginCrossBtn
            // 
            this.loginCrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginCrossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginCrossBtn.Location = new System.Drawing.Point(691, 12);
            this.loginCrossBtn.Name = "loginCrossBtn";
            this.loginCrossBtn.Size = new System.Drawing.Size(48, 33);
            this.loginCrossBtn.TabIndex = 10;
            this.loginCrossBtn.Text = "X";
            this.loginCrossBtn.UseVisualStyleBackColor = true;
            this.loginCrossBtn.Click += new System.EventHandler(this.loginCrossBtn_Click);
            // 
            // AddRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(752, 556);
            this.Controls.Add(this.loginCrossBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addRoutineClassLinkTb);
            this.Controls.Add(this.addRoutineClassEndTb);
            this.Controls.Add(this.addRoutineClassStartTb);
            this.Controls.Add(this.addRoutineSubmitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addRoutineTeacherNameTb);
            this.Controls.Add(this.addRoutineClassNameTb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRoutine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoutine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addRoutineClassNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRoutineSubmitBtn;
        private System.Windows.Forms.TextBox addRoutineTeacherNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addRoutineClassLinkTb;
        private System.Windows.Forms.TextBox addRoutineClassEndTb;
        private System.Windows.Forms.TextBox addRoutineClassStartTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginCrossBtn;
    }
}