using ActivityMonitor.ApplicationImp;
using System;
using System.Collections.Generic;

namespace ActivityMonitor.Collections
{
    public interface IApplicationUsage
    {
        DateTime BeginTime { get; }
        DateTime EndTime { get; }
        void Start();
        void End();
        void AddScreenShot(ApplicationScreenshots screenshots);
        TimeSpan Total { get; }
        bool IsClosed { get; }
    }
}