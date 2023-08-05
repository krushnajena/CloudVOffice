using CloudVOffice.Attendance.Mantra.MFS100.Agent.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudVOffice.Attendance.Mantra.MFS100.Agent
{
	public partial class RegisterFingerPrint : Form
	{
		private string datapath = Application.StartupPath + "\\FingerData";
		private readonly AttendanceModule _attendanceModule;
		public RegisterFingerPrint()
		{
			InitializeComponent();
			_attendanceModule = AttendanceModule.GetInstance;
			try
			{
				if (!Directory.Exists(datapath))
				{
					Directory.CreateDirectory(datapath);
				}
				//_attendanceModule.OnMFS100Detached();
				_attendanceModule.TransType = "Register";
				//
				//_attendanceModule.OnMFS100Attached();
			}
			catch (Exception ex)
			{
				
			}
		}

		private void btn_RegisterFinger_Click(object sender, EventArgs e)
		{

		}

		private void btn_Capture1_Click(object sender, EventArgs e)
		{
			if (txt_EmployeeCode.Text!=""){

				_attendanceModule.CapCode = 1;
				_attendanceModule.EmployeeCode =txt_EmployeeCode.Text;
				_attendanceModule.StartCapturing();
			}

		}

		private void btn_Capture2_Click(object sender, EventArgs e)
		{
			if (txt_EmployeeCode.Text != "")
			{
				_attendanceModule.CapCode = 2;
				_attendanceModule.EmployeeCode = txt_EmployeeCode.Text;
				_attendanceModule.StartCapturing();
			}
		}

		private void btn_Capture3_Click(object sender, EventArgs e)
		{
			if (txt_EmployeeCode.Text != "")
			{
				_attendanceModule.CapCode = 3;
				_attendanceModule.EmployeeCode = txt_EmployeeCode.Text;
				_attendanceModule.StartCapturing();
			}
		}
	}
}
