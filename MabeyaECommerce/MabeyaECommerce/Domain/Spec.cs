using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace MabeyaECommerce.Domain;

public class Spec 
{
    public Guid Id { get; set; }
    required
    public DateTime CreatedAt { get; set; }
    [Display(Name="Aktiflik")]
    public bool IsEnabled { get; set; } = true;
    [Display(Name = "Ad")]
    public string Name { get; set; }
    [Display(Name = "Kategoriler")]  
    public Guid? categoryId { get; set; }
    public Category? Category { get; set; }

}
public class SpecConfiguration : IEntityTypeConfiguration<Spec>
{
    public void Configure(EntityTypeBuilder<Spec> builder)
    {
        builder
            .ToTable("Spec");

        builder
            .HasIndex(p => new { p.Name});

        

        builder
            .Property(p => p.Name)
            .IsRequired();

        builder
            .Property(p => p.categoryId)
            .IsRequired();

    }
}