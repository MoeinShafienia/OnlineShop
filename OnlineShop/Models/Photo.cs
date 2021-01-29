using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Photo
    {
        public Photo()
        {
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public byte[] Photo1 { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
