namespace eClassroom
{
    partial class AddVideo
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
            this.addVideoNameTb = new System.Windows.Forms.TextBox();
            this.addVideoProvidedbyTb = new System.Windows.Forms.TextBox();
            this.addVideoLinkTb = new System.Windows.Forms.TextBox();
            this.addVideoSubmitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crossBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provided by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Link";
            // 
            // addVideoNameTb
            // 
            this.addVideoNameTb.Location = new System.Drawing.Point(292, 223);
            this.addVideoNameTb.Name = "addVideoNameTb";
            this.addVideoNameTb.Size = new System.Drawing.Size(232, 26);
            this.addVideoNameTb.TabIndex = 3;
            // 
            // addVideoProvidedbyTb
            // 
            this.addVideoProvidedbyTb.Location = new System.Drawing.Point(292, 283);
            this.addVideoProvidedbyTb.Name = "addVideoProvidedbyTb";
            this.addVideoProvidedbyTb.Size = new System.Drawing.Size(232, 26);
            this.addVideoProvidedbyTb.TabIndex = 3;
            // 
            // addVideoLinkTb
            // 
            this.addVideoLinkTb.Location = new System.Drawing.Point(292, 349);
            this.addVideoLinkTb.Name = "addVideoLinkTb";
            this.addVideoLinkTb.Size = new System.Drawing.Size(232, 26);
            this.addVideoLinkTb.TabIndex = 3;
            // 
            // addVideoSubmitBtn
            // 
            this.addVideoSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVideoSubmitBtn.Location = new System.Drawing.Point(255, 433);
            this.addVideoSubmitBtn.Name = "addVideoSubmitBtn";
            this.addVideoSubmitBtn.Size = new System.Drawing.Size(153, 36);
            this.addVideoSubmitBtn.TabIndex = 4;
            this.addVideoSubmitBtn.Text = "Submit";
            this.addVideoSubmitBtn.UseVisualStyleBackColor = true;
            this.addVideoSubmitBtn.Click += new System.EventHandler(this.addVideoSubmitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eClassroom.Properties.Resources.add_video_;
            this.pictureBox1.Location = new System.Drawing.Point(292, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // crossBtn
            // 
            this.crossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.crossBtn.Location = new System.Drawing.Point(615, 21);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(43, 33);
            this.crossBtn.TabIndex = 7;
            this.crossBtn.Text = "X";
            this.crossBtn.UseVisualStyleBackColor = true;
            this.crossBtn.Click += new System.EventHandler(this.crossBtn_Click);
            // 
            // AddVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(670, 533);
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addVideoSubmitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addVideoLinkTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addVideoProvidedbyTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addVideoNameTb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddVideo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addVideoNameTb;
        private System.Windows.Forms.TextBox addVideoProvidedbyTb;
        private System.Windows.Forms.TextBox addVideoLinkTb;
        private System.Windows.Forms.Button addVideoSubmitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button crossBtn;
    }
}