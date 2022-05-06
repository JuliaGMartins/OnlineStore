using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Products.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }

        public String ProductName { get; set; }

        public String ProductDescription { get;  set; }

        public ProductColor Color { get;  set; }

        public ProductCategory Category { get; set; }

        public String ProductImageURL { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
