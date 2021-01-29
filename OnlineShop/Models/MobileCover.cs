using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class MobileCover
    {
        public int Id { get; set; }
        public string CoverType { get; set; }
        public string MobileBrand { get; set; }
        public string MobileName { get; set; }
        public string Color { get; set; }
        public string Speciality { get; set; }

        public virtual MobileAccessory IdNavigation { get; set; }
    }
}
