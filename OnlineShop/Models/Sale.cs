using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Sale
    {
        public int Id { get; set; }
        public int UesrId { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Uesr { get; set; }
    }
}
