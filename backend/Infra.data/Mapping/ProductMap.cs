using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Products.Entities;

namespace Infra.data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(prop => prop.ProductId)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(prop => prop.ProductName)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(prop => prop.ProductDescription)
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(prop => prop.Color)
                .IsRequired();

            builder.Property(prop => prop.Category)
                .IsRequired();

            builder.Property(prop => prop.ProductImageURL)
                .IsRequired();

            builder.Property(prop => prop.ProductPrice)
                .HasPrecision(18, 2)
                .IsRequired();
        }
    }
}