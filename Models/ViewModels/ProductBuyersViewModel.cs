using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplexViews.Models;

namespace ComplexViews.ViewModels
{
    public class ProductBuyersViewModel
    {
        public Products product;
        public IEnumerable<Customers> customers;

        public ProductBuyersViewModel()
        {
        }

    }
}
