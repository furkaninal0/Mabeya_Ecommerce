using MabeyaECommerce.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class Catalog : _EntityBase
{
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

