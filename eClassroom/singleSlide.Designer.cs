namespace eClassroom
{
    partial class singleSlide
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
            this.singleSlideNameLb = new System.Windows.Forms.Label();
            this.singleSlideProvidedbyLb = new System.Windows.Forms.Label();
            this.singleSlideDateTimeLb = new System.Windows.Forms.Label();
            this.crossBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // singleSlideNameLb
            // 
            this.singleSlideNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleSlideNameLb.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleSlideNameLb.Location = new System.Drawing.Point(150, 28);
            this.singleSlideNameLb.Name = "singleSlideNameLb";
            this.singleSlideNameLb.Size = new System.Drawing.Size(311, 27);
            this.singleSlideNameLb.TabIndex = 1;
            this.singleSlideNameLb.Text = "Visual Programming";
            // 
            // singleSlideProvidedbyLb
            // 
            this.singleSlideProvidedbyLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleSlideProvidedbyLb.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleSlideProvidedbyLb.Location = new System.Drawing.Point(151, 84);
            this.singleSlideProvidedbyLb.Name = "singleSlideProvidedbyLb";
            this.singleSlideProvidedbyLb.Size = new System.Drawing.Size(310, 24);
            this.singleSlideProvidedbyLb.TabIndex = 2;
            this.singleSlideProvidedbyLb.Text = "Khaleda Papry";
            // 
            // singleSlideDateTimeLb
            // 
            this.singleSlideDateTimeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleSlideDateTimeLb.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleSlideDateTimeLb.Location = new System.Drawing.Point(664, 102);
            this.singleSlideDateTimeLb.Name = "singleSlideDateTimeLb";
            this.singleSlideDateTimeLb.Size = new System.Drawing.Size(170, 21);
            this.singleSlideDateTimeLb.TabIndex = 3;
            this.singleSlideDateTimeLb.Text = "10:30 AM  20/02/97";
            // 
            // crossBtn
            // 
            this.crossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.crossBtn.Location = new System.Drawing.Point(782, 38);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(43, 33);
            this.crossBtn.TabIndex = 4;
            this.crossBtn.Text = "X";
            this.crossBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eClassroom.Properties.Resources.slide_icon;
            this.pictureBox1.Location = new System.Drawing.Point(30, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // singleSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.singleSlideDateTimeLb);
            this.Controls.Add(this.singleSlideProvidedbyLb);
            this.Controls.Add(this.singleSlideNameLb);
            this.Name = "singleSlide";
            this.Size = new System.Drawing.Size(877, 144);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label singleSlideNameLb;
        private System.Windows.Forms.Label singleSlideProvidedbyLb;
        private System.Windows.Forms.Label singleSlideDateTimeLb;
        private System.Windows.Forms.Button crossBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
