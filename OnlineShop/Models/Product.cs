using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Product
    {
        public Product()
        {
            CompanyProducts = new HashSet<CompanyProduct>();
            Reviews = new HashSet<Review>();
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public bool? FastShipping { get; set; }
        public double ProductWeight { get; set; }
        public int Stock { get; set; }
        public string Size { get; set; }
        public int? SalesNumber { get; set; }
        public string Promotion { get; set; }
        public double? Discount { get; set; }
        public bool? SpecialOffer { get; set; }

        public virtual ComputerAccessory ComputerAccessory { get; set; }
        public virtual Laptop Laptop { get; set; }
        public virtual Mobile Mobile { get; set; }
        public virtual MobileAccessory MobileAccessory { get; set; }
        public virtual ICollection<CompanyProduct> CompanyProducts { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
