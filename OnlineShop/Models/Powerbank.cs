using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Powerbank
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int VIn { get; set; }
        public int VOut { get; set; }
        public int IIn { get; set; }
        public int IOut { get; set; }
        public int PortNumber { get; set; }

        public virtual MobileAccessory IdNavigation { get; set; }
    }
}
