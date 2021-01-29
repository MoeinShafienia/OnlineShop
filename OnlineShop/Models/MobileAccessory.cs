using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class MobileAccessory
    {
        public int Id { get; set; }

        public virtual Product IdNavigation { get; set; }
        public virtual MobileCover MobileCover { get; set; }
        public virtual MobileHolder MobileHolder { get; set; }
        public virtual Powerbank Powerbank { get; set; }
    }
}
