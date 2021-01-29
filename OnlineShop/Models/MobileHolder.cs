using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class MobileHolder
    {
        public int Id { get; set; }
        public string HolderType { get; set; }
        public bool? Speaker { get; set; }
        public bool? Charger { get; set; }
        public bool? Chargable { get; set; }

        public virtual MobileAccessory IdNavigation { get; set; }
    }
}
