using ActivityMonitor.ApplicationImp;
using System;

namespace ActivityMonitor.Collections
{
    public interface IApplicationUsage
    {
        DateTime BeginTime { get; }
        DateTime EndTime { get; }
        void Start();
        void End();
        void AddScreenShot(ApplicationScreenshots screenshots);
        void AddKeystrokes(string keystrokes);

        TimeSpan Total { get; }
        bool IsClosed { get; }
    }
}