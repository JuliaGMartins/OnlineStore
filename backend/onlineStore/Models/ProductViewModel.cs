using OnlineStore.Domain.Products.Entities;

namespace OnlineStore.API.Models
{
    public class ProductViewModel
    {
        //public ProductViewModel(Domain.Products.Entities.Product product)
        //{
        //    this.ProductName = product.ProductName;
        //    this.ProductDescription = product.ProductDescription;
        //    this.Color = product.Color;
        //    this.Category = product.Category;
        //    this.ProductImageURL = product.ProductImageURL;
        //    this.ProductPrice = product.ProductPrice;
        //}

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public ProductColor Color { get; set; }

        public ProductCategory Category { get; set; }

        public String ProductImageURL { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
