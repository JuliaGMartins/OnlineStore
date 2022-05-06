using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Orders.Entities;

namespace Infra.data.Context
{
    internal class OrderItemMap : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {

            builder.Property(prop => prop.Id)
                .HasColumnName("Id");

            builder.Property(prop => prop.ProductId)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(prop => prop.OrderCode)
                .IsRequired();

            builder.Property(prop => prop.Quantity)
                .IsRequired();

            builder.Property(prop => prop.Total)
                .HasPrecision(18, 2)
                .IsRequired();
        }
    }
}