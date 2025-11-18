using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace MabeyaECommerce.Domain;

public class Category 
{

    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    
    [Display(Name = "Ad")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
    public string? Name { get; set; }
    [Display(Name = "Aktif")]
    public bool IsEnabled { get; set; } = true;
    public ICollection <Product> Products { get; set; } = new List<Product> ();
    public ICollection <Spec> Specs { get; set; } = new List<Spec> ();

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