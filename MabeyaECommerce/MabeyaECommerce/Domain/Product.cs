using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class Product
{
    public Guid Id { get; set; }
    public required Guid CategoryId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public byte[] Photo { get; set; }

    public Category? Category { get; set; }
    public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();          

}

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
           .ToTable("Product");          
        builder
           .HasIndex(p => new { p.Name })
           .IsUnique(false)
           .IsDescending(true);
           

        builder
            .HasMany(p=>p.Comments)
            .WithOne(p=>p.Product)
            .HasForeignKey(p=>p.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
