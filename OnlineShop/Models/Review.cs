using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public int UesrId { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public string Strengths { get; set; }
        public string Weaknesses { get; set; }
        public int? PhotoId { get; set; }

        public virtual Photo Photo { get; set; }
        public virtual Product Product { get; set; }
        public virtual Customer Uesr { get; set; }
    }
}
