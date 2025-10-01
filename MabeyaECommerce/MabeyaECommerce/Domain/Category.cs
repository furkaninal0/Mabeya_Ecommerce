using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class Category : _EntityBase
{
    public string Name { get; set; }
    public byte[] Image { get; set; }

    public ICollection <Product> Products { get; set; } = new List<Product> ();

}

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .ToTable("Category");

        builder
            .Property(p => p.Name)
            .IsRequired();

        builder
                .HasMany(p => p.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
                

    }
}