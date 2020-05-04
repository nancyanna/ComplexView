using System;
using System.Collections.Generic;

namespace ComplexViews.Models
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
