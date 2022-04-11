namespace eClassroom
{
    partial class SingleStdInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.singleStdIDTb = new System.Windows.Forms.Label();
            this.singleInfoNameLb = new System.Windows.Forms.Label();
            this.singleInfoPhoneLb = new System.Windows.Forms.Label();
            this.crossBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // singleStdIDTb
            // 
            this.singleStdIDTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleStdIDTb.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleStdIDTb.Location = new System.Drawing.Point(163, 64);
            this.singleStdIDTb.Name = "singleStdIDTb";
            this.singleStdIDTb.Size = new System.Drawing.Size(310, 24);
            this.singleStdIDTb.TabIndex = 2;
            this.singleStdIDTb.Text = "Student ID: 174111";
            // 
            // singleInfoNameLb
            // 
            this.singleInfoNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleInfoNameLb.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleInfoNameLb.Location = new System.Drawing.Point(146, 16);
            this.singleInfoNameLb.Name = "singleInfoNameLb";
            this.singleInfoNameLb.Size = new System.Drawing.Size(311, 27);
            this.singleInfoNameLb.TabIndex = 3;
            this.singleInfoNameLb.Text = "Pappuraj Bhottachrjee";
            // 
            // singleInfoPhoneLb
            // 
            this.singleInfoPhoneLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleInfoPhoneLb.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleInfoPhoneLb.Location = new System.Drawing.Point(163, 103);
            this.singleInfoPhoneLb.Name = "singleInfoPhoneLb";
            this.singleInfoPhoneLb.Size = new System.Drawing.Size(310, 24);
            this.singleInfoPhoneLb.TabIndex = 2;
            this.singleInfoPhoneLb.Text = "Phone: 01832755401";
            // 
            // crossBtn
            // 
            this.crossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.crossBtn.Location = new System.Drawing.Point(774, 58);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(43, 33);
            this.crossBtn.TabIndex = 5;
            this.crossBtn.Text = "X";
            this.crossBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eClassroom.Properties.Resources.info_icon;
            this.pictureBox1.Location = new System.Drawing.Point(40, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SingleStdInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.singleInfoPhoneLb);
            this.Controls.Add(this.singleStdIDTb);
            this.Controls.Add(this.singleInfoNameLb);
            this.Name = "SingleStdInfo";
            this.Size = new System.Drawing.Size(863, 147);
            this.Click += new System.EventHandler(this.SingleStdInfo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label singleStdIDTb;
        private System.Windows.Forms.Label singleInfoNameLb;
        private System.Windows.Forms.Label singleInfoPhoneLb;
        private System.Windows.Forms.Button crossBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
