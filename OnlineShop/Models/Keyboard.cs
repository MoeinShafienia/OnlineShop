using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Keyboard
    {
        public int Id { get; set; }
        public bool? WaterProof { get; set; }
        public bool? HeadsetPort { get; set; }
        public int? UsbPort { get; set; }
        public bool BackgroundLight { get; set; }
        public bool PersianWords { get; set; }

        public virtual ComputerAccessory IdNavigation { get; set; }
    }
}
