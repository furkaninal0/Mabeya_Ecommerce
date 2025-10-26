using MabeyaECommerce.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace MabeyaECommerce.Domain;

public class Catalog 
{
    public Guid Id { get; set; }
    public Guid userId { get; set; }
    public DateTime CreatedAt { get; set; }
    [Display(Name = "Aktif")]

    public bool IsEnabled { get; set; } = true;
    [Display(Name = "Ad")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
    public string Name { get; set; }


   public ICollection<Product> Products { get; set; } = new List<Product>();

}

 public class CatalogConfiguration : IEntityTypeConfiguration<Catalog>
{
    public void Configure(EntityTypeBuilder<Catalog> builder)
    {
        builder
           .ToTable("Catalogs");
        builder.Property(p => p.Name)
            .IsRequired();
       

    }
}

