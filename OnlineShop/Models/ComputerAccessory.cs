using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class ComputerAccessory
    {
        public int Id { get; set; }

        public virtual Product IdNavigation { get; set; }
        public virtual AssembledCase AssembledCase { get; set; }
        public virtual ExternalHard ExternalHard { get; set; }
        public virtual Keyboard Keyboard { get; set; }
        public virtual Monitor Monitor { get; set; }
    }
}
