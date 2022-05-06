using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Products.Entities;
using OnlineStore.Domain.Products.Interfaces.Repository;
using OnlineStore.Domain.Products.Interfaces.Services;

namespace OnlineStore.Domain.Products.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;

        }

        public Product Create(Product product)
        {
            product.ProductId = Guid.NewGuid();

            productRepository.Create(product);
            productRepository.Commit();

            return product;
        }

        public Product Update(Product product)
        {
            productRepository.Update(product);
            productRepository.Commit();
            return product;
        }

        public void Delete(Guid productId)
        {
            productRepository.Delete(productId);
            productRepository.Commit();
        }

        public Product GetProductById(Guid productId)
        {
            return productRepository.GetProductById(productId);
        }

        public IEnumerable<Product> GetByName(string productName)
        {
            return productRepository.GetByName(productName);
        }

        public IEnumerable<Product> GetByCategory(int productCategory)
        {
            return productRepository.GetByCategory((ProductCategory)productCategory);
        }

        public IEnumerable<Product> GetByColor(int productColor)
        {
            return productRepository.GetByColor((ProductColor)productColor);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }
    }
}
