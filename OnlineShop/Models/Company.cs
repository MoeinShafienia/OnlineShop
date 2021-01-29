using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Company
    {
        public Company()
        {
            CompanyProducts = new HashSet<CompanyProduct>();
        }

        public int CertificateNumber { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyAddress { get; set; }

        public virtual ICollection<CompanyProduct> CompanyProducts { get; set; }
    }
}
