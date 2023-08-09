namespace CloudVOffice.Attendance.Mantra.MFS100.Agent
{
	partial class ApplicationSetting
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
			this.txt_ApplicationUrl = new System.Windows.Forms.TextBox();
			this.btn_set = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_ApplicationUrl
			// 
			this.txt_ApplicationUrl.Location = new System.Drawing.Point(12, 70);
			this.txt_ApplicationUrl.Name = "txt_ApplicationUrl";
			this.txt_ApplicationUrl.Size = new System.Drawing.Size(302, 20);
			this.txt_ApplicationUrl.TabIndex = 0;
			// 
			// btn_set
			// 
			this.btn_set.Location = new System.Drawing.Point(197, 111);
			this.btn_set.Name = "btn_set";
			this.btn_set.Size = new System.Drawing.Size(117, 23);
			this.btn_set.TabIndex = 1;
			this.btn_set.Text = "Set Gateway Url";
			this.btn_set.UseVisualStyleBackColor = true;
			this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
			// 
			// ApplicationSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 191);
			this.Controls.Add(this.btn_set);
			this.Controls.Add(this.txt_ApplicationUrl);
			this.Name = "ApplicationSetting";
			this.Text = "ApplicationSetting";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_ApplicationUrl;
		private System.Windows.Forms.Button btn_set;
	}
}