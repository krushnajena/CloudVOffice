using System;
using System.Windows.Forms;

namespace CloudVOffice.Attendance.Mantra.MFS100.Agent
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterFingerPrint registerFingerPrint = new RegisterFingerPrint();
            registerFingerPrint.ShowDialog();
        }
    }
}
