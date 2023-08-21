using System;
using System.Windows.Forms;

namespace CloudVOffice.Attendance.Mantra.MFS100.Agent
{
    public partial class MainWindow : Form
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Date.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }


        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            ManagerLogin manager = new ManagerLogin();
            manager.ShowDialog();
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ApplicationUrl == "")
            {
                ApplicationSetting application = new ApplicationSetting();
                application.ShowDialog();
            }
            else
            {
                ManagerLogin manager = new ManagerLogin();
                manager.ShowDialog();
            }
        }
    }
}
