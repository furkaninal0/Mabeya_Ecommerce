using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class ProductDetails
{
    public Guid productId { get; set; }
    public Guid specId { get; set; }
    public string Value { get; set; }
    public Product? Product { get; set; }
    public Spec? Spec { get; set; }

}
public class ProductDetailsConfiguration : IEntityTypeConfiguration<ProductDetails>
{
    public void Configure(EntityTypeBuilder<ProductDetails> builder)
    {
        builder.ToTable("ProductDetails");

        builder.HasKey(p => new { p.productId, p.specId });

        builder.Property(p => p.Value)
            .IsRequired();

    }
}