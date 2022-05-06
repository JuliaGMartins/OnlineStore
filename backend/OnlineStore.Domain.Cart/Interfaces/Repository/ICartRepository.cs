using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Carts.Entities;

namespace OnlineStore.Domain.Carts.Interfaces.Repository
{
    public interface ICartRepository
    {
        void Create(Cart cart);

        void AddCartItem(Guid productId, int userId);

        void DeleteCartItem(Guid productId, int userId);

        Cart GetCartByUser(String userName);

        void DeleteCart(Guid cartId);

        void Commit();
    }
}
