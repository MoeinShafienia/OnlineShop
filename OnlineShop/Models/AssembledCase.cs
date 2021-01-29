using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class AssembledCase
    {
        public int Id { get; set; }
        public string CaseType { get; set; }
        public int Ram { get; set; }
        public int Storage { get; set; }
        public string Cpu { get; set; }

        public virtual ComputerAccessory IdNavigation { get; set; }
    }
}
