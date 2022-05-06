using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Products.Entities;

namespace OnlineStore.Domain.Products.Interfaces.Services
{
    public interface IProductService
    {
        Product Create(Product product);

        Product Update(Product product);

        void Delete(Guid ProductId);

        public Product GetProductById(Guid productId);

        IEnumerable<Product> GetByName(string productName);

        IEnumerable<Product> GetByCategory(int productCategory);

        IEnumerable<Product> GetByColor(int productColor);

        IEnumerable<Product> GetProducts();


    }
}
