using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Carts.Entities;

namespace Infra.data.Context
{
    public class CartMap : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.Property(prop => prop.Id)
                .HasColumnName("Id");

            builder.Property(prop => prop.Username)
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(prop => prop.TotalPrice)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.HasMany(prop => prop.Item)
                .WithOne()
                .HasForeignKey(prop => prop.Id);
        }
    }
}