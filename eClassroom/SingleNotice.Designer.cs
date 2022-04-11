namespace eClassroom
{
    partial class SingleNotice
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
            this.SingleNoticeLb = new System.Windows.Forms.Label();
            this.SingleNoticeSenderLb = new System.Windows.Forms.Label();
            this.SingleDateTimeLb = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.singleNoticeEditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SingleNoticeLb
            // 
            this.SingleNoticeLb.AutoSize = true;
            this.SingleNoticeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleNoticeLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SingleNoticeLb.Location = new System.Drawing.Point(156, 18);
            this.SingleNoticeLb.Name = "SingleNoticeLb";
            this.SingleNoticeLb.Size = new System.Drawing.Size(246, 25);
            this.SingleNoticeLb.TabIndex = 0;
            this.SingleNoticeLb.Text = "This is a demo label text";
            // 
            // SingleNoticeSenderLb
            // 
            this.SingleNoticeSenderLb.AutoSize = true;
            this.SingleNoticeSenderLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleNoticeSenderLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SingleNoticeSenderLb.Location = new System.Drawing.Point(157, 133);
            this.SingleNoticeSenderLb.Name = "SingleNoticeSenderLb";
            this.SingleNoticeSenderLb.Size = new System.Drawing.Size(201, 20);
            this.SingleNoticeSenderLb.TabIndex = 1;
            this.SingleNoticeSenderLb.Text = "Sender: Mamun Rayhan";
            // 
            // SingleDateTimeLb
            // 
            this.SingleDateTimeLb.AutoSize = true;
            this.SingleDateTimeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleDateTimeLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SingleDateTimeLb.Location = new System.Drawing.Point(626, 133);
            this.SingleDateTimeLb.Name = "SingleDateTimeLb";
            this.SingleDateTimeLb.Size = new System.Drawing.Size(165, 20);
            this.SingleDateTimeLb.TabIndex = 1;
            this.SingleDateTimeLb.Text = "10:12PM - 12/02/20";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(852, 182);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape1.BorderWidth = 5;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 193;
            this.lineShape1.X2 = 700;
            this.lineShape1.Y1 = 169;
            this.lineShape1.Y2 = 167;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eClassroom.Properties.Resources.notice_icon;
            this.pictureBox1.Location = new System.Drawing.Point(32, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // singleNoticeEditBtn
            // 
            this.singleNoticeEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleNoticeEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleNoticeEditBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.singleNoticeEditBtn.Location = new System.Drawing.Point(781, 51);
            this.singleNoticeEditBtn.Name = "singleNoticeEditBtn";
            this.singleNoticeEditBtn.Size = new System.Drawing.Size(39, 40);
            this.singleNoticeEditBtn.TabIndex = 5;
            this.singleNoticeEditBtn.Text = "x";
            this.singleNoticeEditBtn.UseVisualStyleBackColor = true;
            this.singleNoticeEditBtn.Click += new System.EventHandler(this.singleNoticeEditBtn_Click);
            // 
            // SingleNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.singleNoticeEditBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SingleDateTimeLb);
            this.Controls.Add(this.SingleNoticeSenderLb);
            this.Controls.Add(this.SingleNoticeLb);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "SingleNotice";
            this.Size = new System.Drawing.Size(852, 182);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SingleNoticeLb;
        private System.Windows.Forms.Label SingleNoticeSenderLb;
        private System.Windows.Forms.Label SingleDateTimeLb;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button singleNoticeEditBtn;
    }
}
