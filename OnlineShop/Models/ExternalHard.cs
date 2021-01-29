using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class ExternalHard
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public bool WaterProof { get; set; }
        public bool WaterResisdent { get; set; }
        public string StorageNoe { get; set; }
        public int Storage { get; set; }

        public virtual ComputerAccessory IdNavigation { get; set; }
    }
}
