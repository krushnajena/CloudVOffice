namespace Desktop.Monitoring.Models
{
    internal class DesktopSessionLineChartData
    {
        public DesktopSessionLineChartData(string xval, double yvalue1, double yvalue2)
        {
            this.Xvalue = xval;
            this.YValue1 = yvalue1;
            this.yValue2 = yvalue2;
        }
        public string Xvalue { get; set; }
        public double YValue1 { get; set; }
        public double yValue2 { get; set; }

    }
}
