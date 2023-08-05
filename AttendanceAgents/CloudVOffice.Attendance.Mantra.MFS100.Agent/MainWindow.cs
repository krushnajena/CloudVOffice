using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

using System.IO;
using System.Windows.Forms;
using MANTRA;

using System.Linq;

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
	}
}
