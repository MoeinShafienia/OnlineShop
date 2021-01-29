using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Laptop
    {
        public int Id { get; set; }
        public string LaptopType { get; set; }
        public string Color { get; set; }
        public int Ram { get; set; }
        public string RamType { get; set; }
        public string Cpu { get; set; }
        public int Storage { get; set; }
        public string Os { get; set; }
        public int Gpu { get; set; }
        public string GpuBrand { get; set; }
        public string Resuloution { get; set; }
        public bool MateScreen { get; set; }
        public double ScreenSize { get; set; }
        public bool TouchScreen { get; set; }

        public virtual Product IdNavigation { get; set; }
    }
}
