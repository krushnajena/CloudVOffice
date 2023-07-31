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
		private delegate void SetTextCallback(int value);
		private delegate void DisplayStatusCallback(string msg, bool isError);
		private const string _ScanLock = "ScanLock";
		private MANTRA.MFS100 mfs100;
		private int quality = 60;

		private int timeout = 20000;
		private DeviceInfo deviceInfo;

		private string msgTitle = "Mantra.MFS100.Attendance";

		private string key = "";

		private IContainer ncomponents;


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
			Control.CheckForIllegalCrossThreadCalls = false;
			ResetLabels();
			mfs100 = new MANTRA.MFS100(key);
			mfs100.OnMFS100Attached += OnMFS100Attached;
			mfs100.OnMFS100Detached += OnMFS100Detached;
			mfs100.OnPreview += OnPreview;
			mfs100.OnCaptureCompleted += OnCaptureCompleted;
			try
			{
				OnMFS100Attached();
				StartCapturing();

				//if (!Directory.Exists(datapath))
				//{
				//	Directory.CreateDirectory(datapath);
				//}
			}
			catch (Exception ex)
			{
				ShowMessage(ex.Message, iserror: true);
			}
		}

		public void ResetLabels()
		{

		}

		private void OnPreview(FingerData fingerprintData)
		{
			try
			{
				if (fingerprintData != null)
				{
					pb_Finger.Image = fingerprintData.FingerImage;
					pb_Finger.Refresh();
					lblStatus.Text = "Quality: " + fingerprintData.Quality;
					lblStatus.Refresh();
				}
			}
			catch (Exception)
			{
			}
		}

		private void OnMFS100Attached()
		{
			try
			{
				int num = mfs100.Init();
				if (num != 0)
				{
					DisplayStatus(mfs100.GetErrorMsg(num), isError: true);
					return;
				}
				deviceInfo = mfs100.GetDeviceInfo();
				if (deviceInfo != null)
				{
					string text = "SERIAL: " + deviceInfo.SerialNo + Environment.NewLine + "MAKE: " + deviceInfo.Make + Environment.NewLine + "MODEL: " + deviceInfo.Model;
					lblSerialNo.Text = text;
				}
				else
				{
					lblSerialNo.Text = "";
				}
				DisplayStatus("Device initialized", isError: false);
			}
			catch (Exception ex)
			{
				DisplayStatus("", isError: true);
				ShowMessage(ex.ToString(), iserror: true);
			}
			finally
			{

			}
		}

		private void OnMFS100Detached()
		{
			try
			{
				ResetLabels();
				
				int num = mfs100.Uninit();
				if (num == 0)
				{
					DisplayStatus("Uninitialized success", isError: false);
				}
				else
				{
					DisplayStatus(mfs100.GetErrorMsg(num), isError: true);
				}
			}
			catch (Exception ex)
			{
				DisplayStatus("", isError: true);
				ShowMessage(ex.ToString(), iserror: true);
			}
			finally
			{
			
			}
		}

		private void StartCapturing()
		{
			try
			{
				SetQuality(0);
				int num = mfs100.StartCapture(quality, timeout, ShowPreview: true);
				if (num != 0)
				{
					ShowMessage(mfs100.GetErrorMsg(num), iserror: true);
				}
			}
			catch (Exception ex)
			{
				ShowMessage(ex.ToString(), iserror: true);
			}
		}

		private void SetQuality(int quality)
		{
			if (lblQuality.InvokeRequired)
			{
				SetTextCallback method = SetQuality;
				if (!base.IsDisposed)
				{
					Invoke(method, quality);
				}
			}
			else
			{
				lblQuality.Text = "Quality: " + quality;
			}
		}

		FingerData nfingerprintData;
		private void OnCaptureCompleted(bool status, int errorCode, string errorMsg, FingerData fingerprintData)
		{
			try
			{

				if (nfingerprintData == null)
				{
					nfingerprintData = fingerprintData;
				}
				else
				{
					int score = 0
						;
					int ret = mfs100.MatchISO(nfingerprintData.ISOTemplate.ToArray(), fingerprintData.ISOTemplate.ToArray(), ref score);
					//if (nfingerprintData.ISOImage == fingerprintData.ISOImage)
					//{

					//}
					//if(nfingerprintData.ISOTemplate == fingerprintData.ISOTemplate)
					//{

					//}
					//if (nfingerprintData.ANSITemplate == fingerprintData.ANSITemplate)
					//{
					//	byte[] b= nfingerprintData.ANSITemplate.ToArray();
					//}

					//if (nfingerprintData.RawData == fingerprintData.RawData)
					//{

					//}

					//if (nfingerprintData.WSQImage == fingerprintData.WSQImage)
					//{

					//}
				}
				//if (status)
				//{
				//	picFinger.Image = fingerprintData.FingerImage;
				//	picFinger.Refresh();
				//	lblStatus.Text = "Success: Quality: " + fingerprintData.Quality + " Nfiq: " + fingerprintData.Nfiq;
				//	File.WriteAllBytes(datapath + "//ISOTemplate.iso", fingerprintData.ISOTemplate);
				//	File.WriteAllBytes(datapath + "//ISOImage.iso", fingerprintData.ISOImage);
				//	File.WriteAllBytes(datapath + "//AnsiTemplate.ansi", fingerprintData.ANSITemplate);
				//	File.WriteAllBytes(datapath + "//RawData.raw", fingerprintData.RawData);
				//	fingerprintData.FingerImage.Save(datapath + "//FingerImage.bmp", ImageFormat.Bmp);
				//	File.WriteAllBytes(datapath + "//WSQImage.wsq", fingerprintData.WSQImage);
				//	ShowMessage("Capture Success.\nFinger data is saved at application path", iserror: false);
				//}
				//else
				//{
				//	lblStatus.Text = "Failed: error: " + errorCode + " (" + errorMsg + ")";
				//}
				lblStatus.Refresh();
			}
			catch (Exception ex)
			{
				ShowMessage(ex.ToString(), iserror: true);
			}
			finally
			{
				GC.Collect();
			}
		}

		public void DisplayStatus(string Msg, bool isError)
		{
			if (lblStatus.InvokeRequired)
			{
				DisplayStatusCallback method = DisplayStatus;
				if (!base.IsDisposed)
				{
					Invoke(method, Msg, isError);
				}
			}
			else
			{
				lblStatus.Text = Msg;
				if (isError)
				{
					lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					lblStatus.ForeColor = Color.White;
				}
			}
			Application.DoEvents();
			Application.DoEvents();
			Application.DoEvents();
			Application.DoEvents();
		}

		private void ShowMessage(string msg, bool iserror)
		{
			MessageBox.Show(msg, msgTitle, MessageBoxButtons.OK, iserror ? MessageBoxIcon.Hand : MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
		}


	}
}
