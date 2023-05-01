namespace ActMon.Forms
{
    partial class ApplicationView
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbApplicationName = new System.Windows.Forms.Label();
            this.lbAppUsage = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.progressBarAdv1 = new System.Windows.Forms.ProgressBar();
            this.lbl_appurl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbApplicationName
            // 
            this.lbApplicationName.AutoSize = true;
            this.lbApplicationName.Location = new System.Drawing.Point(59, 9);
            this.lbApplicationName.Name = "lbApplicationName";
            this.lbApplicationName.Size = new System.Drawing.Size(0, 13);
            this.lbApplicationName.TabIndex = 1;
            // 
            // lbAppUsage
            // 
            this.lbAppUsage.Location = new System.Drawing.Point(211, 3);
            this.lbAppUsage.Name = "lbAppUsage";
            this.lbAppUsage.Size = new System.Drawing.Size(92, 13);
            this.lbAppUsage.TabIndex = 3;
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 1000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(5, 3);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(48, 48);
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.Location = new System.Drawing.Point(59, 38);
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.Size = new System.Drawing.Size(244, 13);
            this.progressBarAdv1.TabIndex = 2;
            // 
            // lbl_appurl
            // 
            this.lbl_appurl.AutoSize = true;
            this.lbl_appurl.Location = new System.Drawing.Point(59, 22);
            this.lbl_appurl.Name = "lbl_appurl";
            this.lbl_appurl.Size = new System.Drawing.Size(0, 13);
            this.lbl_appurl.TabIndex = 4;
            // 
            // ApplicationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_appurl);
            this.Controls.Add(this.lbAppUsage);
            this.Controls.Add(this.progressBarAdv1);
            this.Controls.Add(this.lbApplicationName);
            this.Controls.Add(this.pbIcon);
            this.Name = "ApplicationView";
            this.Size = new System.Drawing.Size(318, 59);
            this.Load += new System.EventHandler(this.ApplicationView_Load);
            this.Resize += new System.EventHandler(this.ApplicationView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbApplicationName;
        private System.Windows.Forms.Label lbAppUsage;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ProgressBar progressBarAdv1;
        private System.Windows.Forms.Label lbl_appurl;
    }
}
