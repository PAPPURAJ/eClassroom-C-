namespace eClassroom
{
    partial class singleRoutine
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.singleRoutineDuration = new System.Windows.Forms.Label();
            this.sinTeachNameLb = new System.Windows.Forms.Label();
            this.singleRoutineSubNameLb = new System.Windows.Forms.Label();
            this.singleRoutineLastUpdateLb = new System.Windows.Forms.Label();
            this.singleRoutineDeleteBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.singleRoutineEditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(866, 134);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape1.BorderWidth = 5;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 160;
            this.lineShape1.X2 = 759;
            this.lineShape1.Y1 = 122;
            this.lineShape1.Y2 = 122;
            // 
            // singleRoutineDuration
            // 
            this.singleRoutineDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleRoutineDuration.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleRoutineDuration.Location = new System.Drawing.Point(139, 85);
            this.singleRoutineDuration.Name = "singleRoutineDuration";
            this.singleRoutineDuration.Size = new System.Drawing.Size(214, 24);
            this.singleRoutineDuration.TabIndex = 0;
            this.singleRoutineDuration.Text = "10:30AM - 12:00PM";
            // 
            // sinTeachNameLb
            // 
            this.sinTeachNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinTeachNameLb.ForeColor = System.Drawing.Color.Cornsilk;
            this.sinTeachNameLb.Location = new System.Drawing.Point(298, 61);
            this.sinTeachNameLb.Name = "sinTeachNameLb";
            this.sinTeachNameLb.Size = new System.Drawing.Size(310, 24);
            this.sinTeachNameLb.TabIndex = 0;
            this.sinTeachNameLb.Text = "Khaleda Papry";
            // 
            // singleRoutineSubNameLb
            // 
            this.singleRoutineSubNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleRoutineSubNameLb.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleRoutineSubNameLb.Location = new System.Drawing.Point(138, 18);
            this.singleRoutineSubNameLb.Name = "singleRoutineSubNameLb";
            this.singleRoutineSubNameLb.Size = new System.Drawing.Size(311, 27);
            this.singleRoutineSubNameLb.TabIndex = 0;
            this.singleRoutineSubNameLb.Text = "Visual Programming";
            // 
            // singleRoutineLastUpdateLb
            // 
            this.singleRoutineLastUpdateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleRoutineLastUpdateLb.ForeColor = System.Drawing.Color.Cornsilk;
            this.singleRoutineLastUpdateLb.Location = new System.Drawing.Point(439, 85);
            this.singleRoutineLastUpdateLb.Name = "singleRoutineLastUpdateLb";
            this.singleRoutineLastUpdateLb.Size = new System.Drawing.Size(281, 24);
            this.singleRoutineLastUpdateLb.TabIndex = 0;
            this.singleRoutineLastUpdateLb.Text = "Last update: 10:30 AM - 20/02/97";
            // 
            // singleRoutineDeleteBtn
            // 
            this.singleRoutineDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleRoutineDeleteBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.singleRoutineDeleteBtn.Location = new System.Drawing.Point(800, 76);
            this.singleRoutineDeleteBtn.Name = "singleRoutineDeleteBtn";
            this.singleRoutineDeleteBtn.Size = new System.Drawing.Size(43, 33);
            this.singleRoutineDeleteBtn.TabIndex = 5;
            this.singleRoutineDeleteBtn.Text = "X";
            this.singleRoutineDeleteBtn.UseVisualStyleBackColor = true;
            this.singleRoutineDeleteBtn.Click += new System.EventHandler(this.singleRoutineDeleteBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eClassroom.Properties.Resources.routine_icon;
            this.pictureBox1.Location = new System.Drawing.Point(20, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // singleRoutineEditBtn
            // 
            this.singleRoutineEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleRoutineEditBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.singleRoutineEditBtn.Location = new System.Drawing.Point(800, 16);
            this.singleRoutineEditBtn.Name = "singleRoutineEditBtn";
            this.singleRoutineEditBtn.Size = new System.Drawing.Size(43, 33);
            this.singleRoutineEditBtn.TabIndex = 7;
            this.singleRoutineEditBtn.Text = "✎";
            this.singleRoutineEditBtn.UseVisualStyleBackColor = true;
            this.singleRoutineEditBtn.Click += new System.EventHandler(this.singleRoutineEditBtn_Click);
            // 
            // singleRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.singleRoutineEditBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.singleRoutineDeleteBtn);
            this.Controls.Add(this.singleRoutineLastUpdateLb);
            this.Controls.Add(this.singleRoutineDuration);
            this.Controls.Add(this.sinTeachNameLb);
            this.Controls.Add(this.singleRoutineSubNameLb);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "singleRoutine";
            this.Size = new System.Drawing.Size(866, 134);
            this.Click += new System.EventHandler(this.singleRoutine_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label singleRoutineDuration;
        private System.Windows.Forms.Label sinTeachNameLb;
        private System.Windows.Forms.Label singleRoutineSubNameLb;
        private System.Windows.Forms.Label singleRoutineLastUpdateLb;
        private System.Windows.Forms.Button singleRoutineDeleteBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button singleRoutineEditBtn;

    }
}
