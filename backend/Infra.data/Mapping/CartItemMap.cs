using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Carts.Entities;

namespace Infra.data.Context
{
    public class CartItemMap : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {

            builder.Property(prop => prop.Id)
               .HasColumnName("Id");

            builder.Property(prop => prop.ProductId)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(prop => prop.Quantity)
                .IsRequired();

            builder.Property(prop => prop.Total)
                .HasPrecision(18, 2)
                .IsRequired();
        }
    }
}