namespace eClassroom
{
    partial class ConnectClass
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
            this.connectClassConnectBtn = new System.Windows.Forms.Button();
            this.connectClassPassLb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connectClassIDLb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectCrossBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectClassConnectBtn
            // 
            this.connectClassConnectBtn.Location = new System.Drawing.Point(144, 240);
            this.connectClassConnectBtn.Name = "connectClassConnectBtn";
            this.connectClassConnectBtn.Size = new System.Drawing.Size(102, 32);
            this.connectClassConnectBtn.TabIndex = 7;
            this.connectClassConnectBtn.Text = "Connect";
            this.connectClassConnectBtn.UseVisualStyleBackColor = true;
            this.connectClassConnectBtn.Click += new System.EventHandler(this.connectClassConnectBtn_Click);
            // 
            // connectClassPassLb
            // 
            this.connectClassPassLb.Location = new System.Drawing.Point(97, 179);
            this.connectClassPassLb.Name = "connectClassPassLb";
            this.connectClassPassLb.Size = new System.Drawing.Size(199, 26);
            this.connectClassPassLb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class password";
            // 
            // connectClassIDLb
            // 
            this.connectClassIDLb.Location = new System.Drawing.Point(97, 93);
            this.connectClassIDLb.Name = "connectClassIDLb";
            this.connectClassIDLb.Size = new System.Drawing.Size(199, 26);
            this.connectClassIDLb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class ID";
            // 
            // connectCrossBtn
            // 
            this.connectCrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectCrossBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.connectCrossBtn.Location = new System.Drawing.Point(327, 12);
            this.connectCrossBtn.Name = "connectCrossBtn";
            this.connectCrossBtn.Size = new System.Drawing.Size(26, 25);
            this.connectCrossBtn.TabIndex = 8;
            this.connectCrossBtn.Text = "X";
            this.connectCrossBtn.UseVisualStyleBackColor = true;
            this.connectCrossBtn.Click += new System.EventHandler(this.connectCrossBtn_Click);
            // 
            // ConnectClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(365, 351);
            this.Controls.Add(this.connectCrossBtn);
            this.Controls.Add(this.connectClassConnectBtn);
            this.Controls.Add(this.connectClassPassLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connectClassIDLb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectClass";
            this.Text = "ConnectClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectClassConnectBtn;
        private System.Windows.Forms.TextBox connectClassPassLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox connectClassIDLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectCrossBtn;
    }
}