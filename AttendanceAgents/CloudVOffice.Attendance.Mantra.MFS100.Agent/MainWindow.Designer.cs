namespace CloudVOffice.Attendance.Mantra.MFS100.Agent
{
	partial class MainWindow
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pb_Finger = new System.Windows.Forms.PictureBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbl_Time = new System.Windows.Forms.Label();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblSerialNo = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblQuality = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pb_Finger)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pb_Finger
			// 
			this.pb_Finger.Image = ((System.Drawing.Image)(resources.GetObject("pb_Finger.Image")));
			this.pb_Finger.Location = new System.Drawing.Point(367, 30);
			this.pb_Finger.Name = "pb_Finger";
			this.pb_Finger.Size = new System.Drawing.Size(152, 192);
			this.pb_Finger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_Finger.TabIndex = 0;
			this.pb_Finger.TabStop = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.lblSerialNo});
			this.statusStrip1.Location = new System.Drawing.Point(0, 288);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(552, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(155, 17);
			this.toolStripStatusLabel1.Text = "https://insider.appman.tech";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(165)))));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.lbl_Date);
			this.panel1.Controls.Add(this.lbl_Time);
			this.panel1.Location = new System.Drawing.Point(13, 51);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(332, 100);
			this.panel1.TabIndex = 3;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbl_Time
			// 
			this.lbl_Time.AutoSize = true;
			this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Time.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbl_Time.Location = new System.Drawing.Point(13, 17);
			this.lbl_Time.Name = "lbl_Time";
			this.lbl_Time.Size = new System.Drawing.Size(64, 25);
			this.lbl_Time.TabIndex = 0;
			this.lbl_Time.Text = "label1";
			// 
			// lbl_Date
			// 
			this.lbl_Date.AutoSize = true;
			this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbl_Date.Location = new System.Drawing.Point(13, 59);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(64, 25);
			this.lbl_Date.TabIndex = 1;
			this.lbl_Date.Text = "label2";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(270, 27);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(48, 48);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(429, 229);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(35, 13);
			this.lblStatus.TabIndex = 5;
			this.lblStatus.Text = "label2";
			// 
			// lblSerialNo
			// 
			this.lblSerialNo.Name = "lblSerialNo";
			this.lblSerialNo.Size = new System.Drawing.Size(118, 17);
			this.lblSerialNo.Text = "toolStripStatusLabel3";
			// 
			// lblQuality
			// 
			this.lblQuality.AutoSize = true;
			this.lblQuality.Location = new System.Drawing.Point(432, 249);
			this.lblQuality.Name = "lblQuality";
			this.lblQuality.Size = new System.Drawing.Size(35, 13);
			this.lblQuality.TabIndex = 6;
			this.lblQuality.Text = "label2";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
			this.ClientSize = new System.Drawing.Size(552, 310);
			this.Controls.Add(this.lblQuality);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.pb_Finger);
			this.Name = "MainWindow";
			this.Text = "MainWindow";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			((System.ComponentModel.ISupportInitialize)(this.pb_Finger)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox pb_Finger;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.Label lbl_Time;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ToolStripStatusLabel lblSerialNo;
		private System.Windows.Forms.Label lblQuality;
	}
}