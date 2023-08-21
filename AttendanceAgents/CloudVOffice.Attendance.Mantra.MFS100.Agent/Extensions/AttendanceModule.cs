using MANTRA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace CloudVOffice.Attendance.Mantra.MFS100.Agent.Extensions
{
    public sealed class AttendanceModule
    {

        private AttendanceModule()
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            mfs100 = new MANTRA.MFS100(key);
            mfs100.OnMFS100Attached += OnMFS100Attached;
            mfs100.OnMFS100Detached += OnMFS100Detached;
            mfs100.OnPreview += OnPreview;
            mfs100.OnCaptureCompleted += OnCaptureCompleted;
            try
            {

                if (!Directory.Exists(datapath))
                {
                    Directory.CreateDirectory(datapath);
                }
                //if (!Directory.Exists(datapath))
                //{
                //	Directory.CreateDirectory(datapath);
                //}
            }
            catch (Exception ex)
            {

            }
        }
        private static AttendanceModule instance = null;
        public static AttendanceModule GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AttendanceModule();
                }
                return instance;
            }
        }
        private delegate void SetTextCallback(int value);
        private delegate void DisplayStatusCallback(string msg, bool isError);
        private const string _ScanLock = "ScanLock";
        public string TransType = "Validate";
        private MANTRA.MFS100 mfs100;
        private int quality = 60;

        private int timeout = 2000000000;
        private DeviceInfo deviceInfo;

        private string datapath = Application.StartupPath + "\\FingerData";
        private string msgTitle = "Mantra.MFS100.Attendance";

        private string key = "";

        private IContainer ncomponents;
        public string EmployeeCode;
        public int CapCode;


        private void OnPreview(FingerData fingerprintData)
        {
            try
            {
                if (fingerprintData != null)
                {
                    //pb_Finger.Image = fingerprintData.FingerImage;
                    //pb_Finger.Refresh();
                    //lblStatus.Text = "Quality: " + fingerprintData.Quality;
                    //lblStatus.Refresh();
                }

            }
            catch (Exception)
            {
            }
        }

        public void OnMFS100Attached()
        {
            try
            {
                int num = mfs100.Init();

                if (num != 0)
                {
                    //DisplayStatus(mfs100.GetErrorMsg(num), isError: true);
                    return;
                }

                deviceInfo = mfs100.GetDeviceInfo();



            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        public void OnMFS100Detached()
        {
            try
            {


                int num = mfs100.Uninit();

            }
            catch (Exception ex)
            {
            }
            finally
            {

            }
        }

        public void StartCapturing()
        {
            try
            {
                //SetQuality(0);
                int num = mfs100.StartCapture(quality, -5000000, ShowPreview: true);

            }
            catch (Exception ex)
            {

            }
        }
        List<FingerData> registerd = new List<FingerData>();

        private void OnCaptureCompleted(bool status, int errorCode, string errorMsg, FingerData fingerprintData)
        {
            try
            {
                if (TransType == "Register")
                {

                    File.WriteAllBytes(datapath + "//" + EmployeeCode + "ISOTemplate" + CapCode + ".iso", fingerprintData.ISOTemplate);
                    File.WriteAllBytes(datapath + "//" + EmployeeCode + "ISOImage" + CapCode + ".iso", fingerprintData.ISOImage);
                    File.WriteAllBytes(datapath + "//" + EmployeeCode + "AnsiTemplate" + CapCode + ".ansi", fingerprintData.ANSITemplate);
                    File.WriteAllBytes(datapath + "//" + EmployeeCode + "RawData" + CapCode + ".raw", fingerprintData.RawData);

                    File.WriteAllBytes(datapath + "//" + EmployeeCode + "WSQImage" + CapCode + ".wsq", fingerprintData.WSQImage);

                    registerd.Add(fingerprintData);


                }

                int score = 0;
                //int ret = mfs100.MatchISO(nfingerprintData.ISOTemplate.ToArray(), fingerprintData.ISOTemplate.ToArray(), ref score);

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


            }
            catch (Exception ex)
            {

            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
