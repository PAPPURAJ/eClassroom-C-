namespace eClassroom
{
    partial class AddSlide
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addSlideNameTb = new System.Windows.Forms.TextBox();
            this.addSlideProvidedbyTb = new System.Windows.Forms.TextBox();
            this.addSlideLinkTb = new System.Windows.Forms.TextBox();
            this.addSlideSubmitBtn = new System.Windows.Forms.Button();
            this.crossBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slide Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provided by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Link";
            // 
            // addSlideNameTb
            // 
            this.addSlideNameTb.Location = new System.Drawing.Point(232, 203);
            this.addSlideNameTb.Name = "addSlideNameTb";
            this.addSlideNameTb.Size = new System.Drawing.Size(232, 26);
            this.addSlideNameTb.TabIndex = 3;
            // 
            // addSlideProvidedbyTb
            // 
            this.addSlideProvidedbyTb.Location = new System.Drawing.Point(232, 266);
            this.addSlideProvidedbyTb.Name = "addSlideProvidedbyTb";
            this.addSlideProvidedbyTb.Size = new System.Drawing.Size(232, 26);
            this.addSlideProvidedbyTb.TabIndex = 3;
            // 
            // addSlideLinkTb
            // 
            this.addSlideLinkTb.Location = new System.Drawing.Point(232, 332);
            this.addSlideLinkTb.Name = "addSlideLinkTb";
            this.addSlideLinkTb.Size = new System.Drawing.Size(232, 26);
            this.addSlideLinkTb.TabIndex = 3;
            // 
            // addSlideSubmitBtn
            // 
            this.addSlideSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSlideSubmitBtn.Location = new System.Drawing.Point(232, 390);
            this.addSlideSubmitBtn.Name = "addSlideSubmitBtn";
            this.addSlideSubmitBtn.Size = new System.Drawing.Size(199, 36);
            this.addSlideSubmitBtn.TabIndex = 4;
            this.addSlideSubmitBtn.Text = "Submit";
            this.addSlideSubmitBtn.UseVisualStyleBackColor = true;
            this.addSlideSubmitBtn.Click += new System.EventHandler(this.addSlideSubmitBtn_Click);
            // 
            // crossBtn
            // 
            this.crossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.crossBtn.Location = new System.Drawing.Point(546, 12);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(48, 33);
            this.crossBtn.TabIndex = 6;
            this.crossBtn.Text = "X";
            this.crossBtn.UseVisualStyleBackColor = true;
            this.crossBtn.Click += new System.EventHandler(this.crossBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eClassroom.Properties.Resources.add_slide;
            this.pictureBox1.Location = new System.Drawing.Point(232, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AddSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(618, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.addSlideSubmitBtn);
            this.Controls.Add(this.addSlideLinkTb);
            this.Controls.Add(this.addSlideProvidedbyTb);
            this.Controls.Add(this.addSlideNameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSlide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSlide";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addSlideNameTb;
        private System.Windows.Forms.TextBox addSlideProvidedbyTb;
        private System.Windows.Forms.TextBox addSlideLinkTb;
        private System.Windows.Forms.Button addSlideSubmitBtn;
        private System.Windows.Forms.Button crossBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}