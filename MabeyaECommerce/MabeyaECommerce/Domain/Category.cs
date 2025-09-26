using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
   
    public ICollection <Product> Products { get; set; } = new HashSet<Product> ();

}

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .ToTable("Category");

        builder
            .HasIndex(p => new { p.Name })
            .IsUnique(true);

        builder
                .HasMany(p => p.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
                

    }
}