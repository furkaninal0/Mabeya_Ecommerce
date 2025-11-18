using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class Address
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public int CityId { get; set; }
    public string? Name { get; set; }
    public string? Text { get; set; }
    public string? Number { get; set; } = "0";
    public string? zipCode { get; set; }
    public City? City { get; set; }
    public User? User { get; set; }
    public bool IsInvoice { get; set; }
    public bool IsShipping { get; set; }
    public string? TaxNumber { get; set; }
    public string? TaxOffice { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; } = false;



}
public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder
           .ToTable("Address");
        builder.Property(p => p.Name)
            .IsRequired();
        builder.Property(p => p.Text)
            .IsRequired();
        builder.Property(p => p.Number)
           .IsRequired();

    }
}
