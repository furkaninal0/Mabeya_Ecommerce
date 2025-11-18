using MabeyaECommerce.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class ProductImages 
{
    public User? User { get; set; }

    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsEnabled { get; set; }
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