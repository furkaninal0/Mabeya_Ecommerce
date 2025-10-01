using MabeyaECommerce.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class ProductImages : _EntityBase
{
    public Guid productId { get; set; }
    public byte[] Image { get; set; }
    public Product? Product { get; set; }

}

public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImages>
{
    public void Configure(EntityTypeBuilder<ProductImages> builder)
    {
        //tpt
        builder.ToTable("ProductImages");

        builder.Property(p => p.Image)
            .IsRequired();

    }

}