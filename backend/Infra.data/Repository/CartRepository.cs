using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.data.Context;
using OnlineStore.Domain.Carts.Entities;
using OnlineStore.Domain.Carts.Interfaces.Repository;

namespace Infra.data.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly CartContext cartContext;

        public CartRepository(CartContext cartContext)
        {
            this.cartContext = cartContext;
        }

        public void AddCartItem(Guid productId, int userId)
        {
            //cartContext.Products.Update(cart);
            //return cart;
        }

        public void Commit()
        {
            cartContext.SaveChanges();
        }

        public Cart Create(Cart cart)
        {
            cartContext.Carts.Add(cart);
            return cart;
        }

        public void DeleteCart(Guid cartId)
        {
            var cart = cartContext.Carts.FirstOrDefault(c => c.Id == cartId);
            cartContext.Remove(cart);
        }

        public void DeleteCartItem(Guid productId, int userId)
        {
            throw new NotImplementedException();
        }

        public Cart GetCartByUser(String userName)
        {
            var cart = cartContext.Carts.FirstOrDefault(c => c.Username == userName);
            return cart;
        }
    }
}
