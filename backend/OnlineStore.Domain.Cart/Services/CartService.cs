using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Carts.Entities;
using OnlineStore.Domain.Carts.Interfaces.Repository;
using OnlineStore.Domain.Carts.Interfaces.Services;

namespace OnlineStore.Domain.Carts.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;

        }

        public void AddCartItem(Guid productId, string userName)
        {
            if (cartRepository.GetCartByUser(userName) == null)
            {
                var cart = new Cart();
                cart.Id = Guid.NewGuid();
                cart.Username = userName;

                cartRepository.Create(cart);
                cartRepository.Commit();
            }
            else
            {

            }
        }

        public void AddCartItem(Guid productId, int userId)
        {
            throw new NotImplementedException();
        }

        public Cart Create(Cart cart)
        {
            return cartRepository.Create(cart);
        }

        public void DeleteCart(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCartItem(Guid productId, int userId)
        {
            throw new NotImplementedException();
        }

        public Cart GetCartByUser(String userName)
        {
            return cartRepository.GetCartByUser(userName);
        }
    }
}
