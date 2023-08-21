using System;
using System.Windows.Forms;

namespace CloudVOffice.Attendance.Mantra.MFS100.Agent
{
    public partial class ApplicationSetting : Form
    {
        public ApplicationSetting()
        {
            InitializeComponent();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ApplicationUrl = txt_ApplicationUrl.Text;

            // Save the changes (important step)
            Properties.Settings.Default.Save();

        }
    }
}
