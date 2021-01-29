using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class CompanyProduct
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ProductId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
    }
}
