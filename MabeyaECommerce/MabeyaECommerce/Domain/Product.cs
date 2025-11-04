using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MabeyaECommerce.Domain;

public class Product 
{
    public Guid Id { get; set; }
    public Guid userId { get; set; }
    public DateTime CreatedAt { get; set; }
    [Display(Name = "Kategori")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
    public Guid CategoryId { get; set; }
    [Display(Name = "Aktif")]
    public bool IsEnabled { get; set; } = true;

    [Display(Name = "Ad")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
    public string? Name { get; set; }
    [Display(Name = "Fiyat")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
    public decimal Price { get; set; }
    [Display(Name = "Özellikler")]
    public string? Description { get; set; }
    public byte[]? Image { get; set; }
    public int Views { get; set; }
    [NotMapped]
    [Display(Name = "Katalog")]
    public Guid[]? SelectedCatalogs { get; set; }

    [NotMapped]
    public IFormFile? ImageFile { get; set; }
    [NotMapped]
    public IFormFile[]? ImageFiles { get; set; }
   
    
    public Category? Category { get; set; }
    public ICollection<Catalog> Catalogs { get; set; } = new List<Catalog>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<ProductImages> ProductImages { get; set; } = new List<ProductImages>();
    public ICollection<ShoppedOrder_Item> ShoppedOrder_Items { get; set; } = new List<ShoppedOrder_Item>();
    [NotMapped]
    public ICollection<SelectedProduct> SelectedProducts { get; set; } = new List<SelectedProduct>();
    public ICollection<ProductDetails> ProductDetails { get; set; } = new List<ProductDetails>();


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
           .HasMany(p => p.ProductImages)
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
