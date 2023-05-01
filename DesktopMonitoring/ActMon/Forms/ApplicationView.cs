using System;
using System.Drawing;
using System.Windows.Forms;
namespace ActMon.Forms
{
    public partial class ApplicationView : UserControl
    {
        private ActivityMonitor.Application.Application _application;
        private ActivityMonitor.ApplicationMonitor.AppMonitor _monitor;

        public BindingSource _bindSrc;
        private string _key;
        public ApplicationView(ActivityMonitor.ApplicationMonitor.AppMonitor monitor)
        {

            _monitor = monitor;
            _initializeControl();
        }
        public ApplicationView(ActivityMonitor.Application.Application application, ActivityMonitor.ApplicationMonitor.AppMonitor monitor)
        {
            _application = application;
            _monitor = monitor;

            _initializeControl();
        }

        private void _initializeControl()
        {
            
            InitializeComponent();

            if (_application != null)
            {
                _bindSrc = new BindingSource();

                // Bind BindingSource1 to the list of states.

                _bindSrc.DataSource = _application;

                lbApplicationName.DataBindings.Add("Text", _bindSrc, "Name", false);
                lbl_appurl.DataBindings.Add("Text", _bindSrc, "App_Name", false);
                lbAppUsage.DataBindings.Add("Text", _bindSrc, "TotalUsageTime", false);
               
                progressBarAdv1.Maximum = 1000;
                //pbApplicationUsage.DataBindings.Add("Text", _bindSrc, "Usage", false);

                _key = _application.ExeName;

                pbIcon.Image = _application.Icon.ToBitmap();
                tmrRefresh.Enabled = true;
            }

            UpdateView();
        }

        public string Key
        {
            get => _key;

        }

        public string AppUsageText
        {
            get => lbAppUsage.Text;
            set
            {
                lbAppUsage.Text = value;
            }
        }
        public int PctValue
        {
            get => progressBarAdv1.Value;
            set
            {
                progressBarAdv1.Maximum = 100;
                progressBarAdv1.Value = value;
            }
        }

        public string ApplicationText
        {
            get => lbApplicationName.Text;
            set
            {
                lbApplicationName.Text = value;
            }
        }
        public string Application_Name
        {
            get => lbl_appurl.Text;
            set
            {
                lbl_appurl.Text = value;
            }
        }

        public Image Icon
        {
            set
            {
                pbIcon.Image = value;
            }
            get => pbIcon.Image;
        }
        public void UpdateView()
        {
            if (_application != null)
            {
                _bindSrc.ResetBindings(false);
                lbAppUsage.Text = _application.TotalUsageTime.ToString(@"hh\:mm\:ss") + " (" + appPct().ToString() + "%)";
                progressBarAdv1.Value = appPct(1000);
            }
        }

        private int appPct(int Multiplier = 100)
        {
            return (int)(_application.TotalUsageTime.TotalSeconds * Multiplier / _monitor.TotalTimeSpentInApplications.TotalSeconds);
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void ApplicationView_Resize(object sender, EventArgs e)
        {
            lbAppUsage.Left = this.Width - lbAppUsage.Width - 10;
            
            progressBarAdv1.Width = lbAppUsage.Left - progressBarAdv1.Left - 10 ;
        }

        public void TriggerResize()
        {
            Width = Parent.Width - 10;
        }

        private void ApplicationView_Load(object sender, EventArgs e)
        {

        }

        private void lbApplicationName_Click(object sender, EventArgs e)
        {

        }
    }
}
