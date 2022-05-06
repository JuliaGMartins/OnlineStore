using Infra.data.Context;
using OnlineStore.Domain.Products.Entities;
using OnlineStore.Domain.Products.Interfaces.Repository;

namespace Infra.data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext productContext;

        public ProductRepository(ProductContext productContext)
        {
            this.productContext = productContext;
        }

        public Product Create(Product product)
        {
            productContext.Products.Add(product);
            return product;
        }

        public void Commit()
        {
            productContext.SaveChanges();
        }

        public void Delete(Guid productId)
        {
            var product = productContext.Products.FirstOrDefault(p => p.ProductId == productId);
            productContext.Remove(product);
        }

        public Product Update(Product product)
        {
            productContext.Products.Update(product);
            return product;
        }

        public Product GetProductById(Guid productId)
        {
            return productContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public IEnumerable<Product> GetByName(string productName)
        {
            return productContext.Products.Where(product => product.ProductName.Contains(productName));
        }

        public IEnumerable<Product> GetProducts()
        {
            return productContext.Products.ToList();
        }

        public IEnumerable<Product> GetByCategory(ProductCategory cat)
        {
            return productContext.Products.Where(product => product.Category == cat);
        }

        public IEnumerable<Product> GetByColor(ProductColor color)
        {
            return productContext.Products.Where(product => product.Color == color);
        }
    }
}
