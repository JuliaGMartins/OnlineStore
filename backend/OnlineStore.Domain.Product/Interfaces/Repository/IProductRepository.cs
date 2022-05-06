using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Products.Entities;

namespace OnlineStore.Domain.Products.Interfaces.Repository
{
    public interface IProductRepository
    {
        Product Create(Product product);

        Product Update(Product product);

        void Delete(Guid productId);

        Product GetProductById(Guid productId);

        IEnumerable<Product> GetByName(string productName);

        IEnumerable<Product> GetByCategory(ProductCategory category);

        IEnumerable<Product> GetByColor(ProductColor color);

        IEnumerable<Product> GetProducts();

        void Commit();
    }
}
