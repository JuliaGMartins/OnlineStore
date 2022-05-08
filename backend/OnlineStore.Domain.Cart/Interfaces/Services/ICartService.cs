using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Carts.Entities;

namespace OnlineStore.Domain.Carts.Interfaces.Services
{
    public interface ICartService
    {
        void AddCartItem(Guid productId, int userId);

        void DeleteCartItem(Guid productId, int userId);

        Cart GetCartByUser(String userName);

        Cart Create(Cart cart);

        void DeleteCart(Guid id);
    }
}
