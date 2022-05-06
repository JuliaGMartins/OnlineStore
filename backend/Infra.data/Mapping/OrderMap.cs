using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Orders.Entities;

namespace Infra.data.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(prop => prop.Id)
                .HasColumnName("Id");

            builder.Property(prop => prop.Code)
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(prop => prop.UserID)
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(prop => prop.CreatedDate)
                .IsRequired();

            builder.Property(prop => prop.UpdatedDate)
                .IsRequired();

            builder.Property(prop => prop.Status)
                .IsRequired();

            builder.Property(prop => prop.TotalPrice)
                .HasPrecision(18,2)
                .IsRequired();

            builder.HasMany(prop => prop.Item)
                .WithOne()
                .HasForeignKey(prop => prop.OrderCode);
        }
    }
}
