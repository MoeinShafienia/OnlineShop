using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Mobile
    {
        public int Id { get; set; }
        public double Camera { get; set; }
        public string Color { get; set; }
        public int Ram { get; set; }
        public string Procceessor { get; set; }
        public int Storage { get; set; }
        public string Os { get; set; }
        public string Resuloution { get; set; }
        public double ScreenSize { get; set; }
        public string Network { get; set; }

        public virtual Product IdNavigation { get; set; }
    }
}
