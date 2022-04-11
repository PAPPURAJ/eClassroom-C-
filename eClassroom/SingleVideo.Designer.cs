namespace eClassroom
{
    partial class SingleVideo
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
            this.singleVideoNameTb = new System.Windows.Forms.Label();
            this.singleVideoProvidedbyTb = new System.Windows.Forms.Label();
            this.sinVideoDateTimeTb = new System.Windows.Forms.Label();
            this.crossBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // singleVideoNameTb
            // 
            this.singleVideoNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleVideoNameTb.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleVideoNameTb.Location = new System.Drawing.Point(171, 14);
            this.singleVideoNameTb.Name = "singleVideoNameTb";
            this.singleVideoNameTb.Size = new System.Drawing.Size(311, 27);
            this.singleVideoNameTb.TabIndex = 0;
            this.singleVideoNameTb.Text = "Visual Programming";
            // 
            // singleVideoProvidedbyTb
            // 
            this.singleVideoProvidedbyTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleVideoProvidedbyTb.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleVideoProvidedbyTb.Location = new System.Drawing.Point(172, 67);
            this.singleVideoProvidedbyTb.Name = "singleVideoProvidedbyTb";
            this.singleVideoProvidedbyTb.Size = new System.Drawing.Size(310, 24);
            this.singleVideoProvidedbyTb.TabIndex = 0;
            this.singleVideoProvidedbyTb.Text = "Khaleda Papry";
            // 
            // sinVideoDateTimeTb
            // 
            this.sinVideoDateTimeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinVideoDateTimeTb.ForeColor = System.Drawing.Color.Cornsilk;
            this.sinVideoDateTimeTb.Location = new System.Drawing.Point(659, 114);
            this.sinVideoDateTimeTb.Name = "sinVideoDateTimeTb";
            this.sinVideoDateTimeTb.Size = new System.Drawing.Size(184, 24);
            this.sinVideoDateTimeTb.TabIndex = 0;
            this.sinVideoDateTimeTb.Text = "10:30 AM - 20/02/97";
            // 
            // crossBtn
            // 
            this.crossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.crossBtn.Location = new System.Drawing.Point(800, 46);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(43, 33);
            this.crossBtn.TabIndex = 5;
            this.crossBtn.Text = "X";
            this.crossBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eClassroom.Properties.Resources.video_icon;
            this.pictureBox1.Location = new System.Drawing.Point(28, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SingleVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sinVideoDateTimeTb);
            this.Controls.Add(this.singleVideoProvidedbyTb);
            this.Controls.Add(this.singleVideoNameTb);
            this.Name = "SingleVideo";
            this.Size = new System.Drawing.Size(866, 152);
            this.Load += new System.EventHandler(this.SingleVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label singleVideoNameTb;
        private System.Windows.Forms.Label singleVideoProvidedbyTb;
        private System.Windows.Forms.Label sinVideoDateTimeTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button crossBtn;
    }
}
