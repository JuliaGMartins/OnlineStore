using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.data.Mapping;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Carts.Entities;

namespace Infra.data.Context
{
    public class CartContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; }

        public CartContext(DbContextOptions<CartContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartMap());
            modelBuilder.ApplyConfiguration(new CartItemMap());
            base.OnModelCreating(modelBuilder);
        }
    }

}
