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
        private readonly ProductContext productContext;

        public CartRepository(CartContext cartContext, ProductContext productContext)
        {
            this.cartContext = cartContext;
            this.productContext = productContext;
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
            if (cart != null)
            {
                cartContext.Remove(cart);
            }
        }

        public void AddCartItem(Guid productId, string userId)
        {
            var product = productContext.Products.FirstOrDefault(p => p.ProductId == productId);
            var cart = cartContext.Carts.FirstOrDefault(c => c.Username == userId);
            if (product != null && cart != null)
            {
                var cartItem = new CartItem {
                    Id = new Guid(),
                    CartId = cart.Id,
                    ProductId = productId,
                    Quantity = 1,
                    Total = product.ProductPrice,

                };
                cart.Item.Add(cartItem);
                cartContext.Carts.Update(cart);
            }

        }

        public void DeleteCartItem(Guid productId, string userId)
        {
            //var product = productContext.Products.FirstOrDefault(p => p.ProductId == productId);
            var cart = cartContext.Carts.FirstOrDefault(c => c.Username == userId);
            if (cart != null)
            {
                var itemToRemove = cart.Item.Find(item => item.ProductId == productId);
                cart.Item.Remove(itemToRemove);
                cartContext.Carts.Update(cart);
            }
        }

        public Cart GetCartByUser(String userName)
        {
            var cart = cartContext.Carts.FirstOrDefault(c => c.Username == userName);
            return cart;
        }
    }
}
