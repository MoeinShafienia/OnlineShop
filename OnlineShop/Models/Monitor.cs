using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Monitor
    {
        public int Id { get; set; }
        public double ScreenSize { get; set; }
        public int UsbPort { get; set; }
        public bool? Speaker { get; set; }
        public int? DviPort { get; set; }
        public int? HtmiPort { get; set; }
        public int? Fps { get; set; }
        public string Resuloution { get; set; }
        public string Color { get; set; }
        public string Panel { get; set; }
        public string BackgroundColor { get; set; }

        public virtual ComputerAccessory IdNavigation { get; set; }
    }
}
