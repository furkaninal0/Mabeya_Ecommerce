using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class Product : _EntityBase
{
    public required Guid CategoryId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public byte[]? Image { get; set; }
    public int Views { get; set; }

    public Category? Category { get; set; }
    public ICollection<Catalog> Catalogs { get; set; } = new List<Catalog>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<ProductImages> ProductImagess { get; set; } = new List<ProductImages>();
    public ICollection<ShoppedOrder_Item> ShoppedOrder_Items { get; set; } = new List<ShoppedOrder_Item>();
    public ICollection<SelectedProduct> SelectedProducts { get; set; } = new List<SelectedProduct>();

}

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
           .ToTable("Products");          
        builder
           .HasIndex(p => new { p.Name })
           .IsUnique(false)
           .IsDescending(true);
        builder.Property(p => p.Name)
           .IsRequired();


        builder
            .HasMany(p=>p.Comments)
            .WithOne(p=>p.Product)
            .HasForeignKey(p=>p.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
        builder
           .HasMany(p => p.ProductImagess)
           .WithOne(p => p.Product)
           .HasForeignKey(p => p.productId)
           .OnDelete(DeleteBehavior.Restrict);
           builder
           .HasMany(p => p.ShoppedOrder_Items)
           .WithOne(p => p.Product)
           .HasForeignKey(p => p.productId)
           .OnDelete(DeleteBehavior.Restrict);
        builder
           .HasMany(p => p.SelectedProducts)
           .WithOne(p => p.Product)
           .HasForeignKey(p => p.productId)
           .OnDelete(DeleteBehavior.Restrict);
    }
}
