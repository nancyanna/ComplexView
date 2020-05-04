using System;
using System.Collections.Generic;

namespace ComplexViews.Models
{
    public partial class Orders
    {
        public int Id { get; set; }
        public string OrderNum { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }

        public Customers Customer { get; set; }
        public Products Product { get; set; }
    }
}
