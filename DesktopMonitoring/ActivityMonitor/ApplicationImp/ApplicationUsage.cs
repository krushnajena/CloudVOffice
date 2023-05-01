using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ActivityMonitor.ApplicationImp;
using ActivityMonitor.Collections;

namespace ActivityMonitor.Application
{
    public class ApplicationUsage : IApplicationUsage
    {
        public ApplicationUsage()
        {
        }

        public ApplicationUsage(DateTime beginTime,
                                DateTime endTime,
                                List<ApplicationScreenshots> screenShots,
                                string detailedName = ""     )
        {
            BeginTime = beginTime;
            EndTime = endTime;
            DetailedName = detailedName;
            ScreenShots = screenShots;

        }

        [XmlAttribute]
        public string DetailedName { get; set; }

        public List<ApplicationScreenshots> ScreenShots { get; set; }
        [XmlAttribute]
        public DateTime BeginTime { get; set; }

        [XmlAttribute]
        public DateTime EndTime { get; set; }


        [XmlAttribute]
        public bool IsClosed { get; set; }
        public bool IsSynced { get; set; } = false;

        public int? SyncId { get; set; }
        public void Start()
        {
            BeginTime = DateTime.Now;
            IsClosed = false;
        }

        public void End()
        {
            EndTime = DateTime.Now;
           
            IsClosed = true;
        }

        public void AddScreenShot(ApplicationScreenshots screenshots)
        {
            if(ScreenShots == null)
            {
                ScreenShots = new List<ApplicationScreenshots>();
            }
            ScreenShots.Add(screenshots);
        }


        public void UpdateSyncTime(int _SyncId)
        {
            SyncId = SyncId;
            IsSynced = true;
        }

        public TimeSpan Total
        {
            get
            {
                return IsClosed ? EndTime.Subtract(BeginTime) : DateTime.Now.Subtract(BeginTime);
            }
        }



    }
}