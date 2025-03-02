using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAB.Data.Entities;

namespace TAB.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.ProductId);

            builder.Property(x => x.ProductId).UseIdentityColumn();

            builder.Property(x => x.ProductName).IsRequired();

            builder.Property(x => x.ProductImage);

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.OriginalPrice).IsRequired();

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.IsFeatured);

            builder.Property(x => x.DateCreated);

            builder.Property(x=>x.Description);


            builder.HasOne(x=>x.Category).WithMany(p=>p.Products).HasForeignKey(x=>x.CategoryIds);
        }
    }
}