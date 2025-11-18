using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class SelectedProduct
{
    
    public Guid Id { get; set; }
    public Guid? UserId { get; set; }
    public Guid productId { get; set; }
    public int Quantity { get; set; }
    public User? User { get; set; }
    public Product? Product { get; set; }

}

public class SelectedProductConfiguration : IEntityTypeConfiguration<SelectedProduct>
{
    public void Configure(EntityTypeBuilder<SelectedProduct> builder)
    {
        builder.ToTable("SelectedProduct");


    }
}
