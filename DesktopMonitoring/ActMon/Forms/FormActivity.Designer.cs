namespace ActMon.Forms
{
    partial class FormActivity
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActivity));
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.flApplicationsUsage = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btn_stopMonitering = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 1000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // flApplicationsUsage
            // 
            resources.ApplyResources(this.flApplicationsUsage, "flApplicationsUsage");
            this.flApplicationsUsage.Name = "flApplicationsUsage";
            this.flApplicationsUsage.Resize += new System.EventHandler(this.flApplicationsUsage_OnResize);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // btn_stopMonitering
            // 
            this.btn_stopMonitering.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.btn_stopMonitering, "btn_stopMonitering");
            this.btn_stopMonitering.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_stopMonitering.Name = "btn_stopMonitering";
            this.btn_stopMonitering.UseVisualStyleBackColor = false;
            this.btn_stopMonitering.Click += new System.EventHandler(this.btn_stopMonitering_Click);
            // 
            // FormActivity
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_stopMonitering);
            this.Controls.Add(this.flApplicationsUsage);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActivity";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.FormActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.FlowLayoutPanel flApplicationsUsage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn_stopMonitering;
    }
}

