using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid provinceId { get; set; }
    public Province? Province { get; set; }

    public ICollection<Address> Addresses { get; set; } = new List<Address>();

}
public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder
            .ToTable("Cities");
        builder.HasIndex(p => new { p.Name, p.provinceId })
            .IsUnique();

        builder
            .Property(p => p.Name)
            .IsRequired();

        builder
                .HasMany(p => p.Addresses)
                .WithOne(p => p.City!)
                .HasForeignKey(p => p.cityId)
                .OnDelete(DeleteBehavior.Restrict);


    }
}