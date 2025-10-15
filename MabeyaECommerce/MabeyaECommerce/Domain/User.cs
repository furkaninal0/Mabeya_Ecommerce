using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;


public enum Genders
{
    Female, Male
}

public class User :IdentityUser<Guid>
{
    public required string givenName { get; set; }    
    public DateTime Date{ get; set; }
    public Genders Gender{ get; set; }
    public bool IsEnabled { get; set; } = true;

    public ICollection<Address> Addresses { get; set; } = new List<Address>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<ShoppedOrder> ShoppedOrders { get; set; } = new List<ShoppedOrder>();
    public ICollection<SelectedProduct> SelectedProducts { get; set; } = new List<SelectedProduct>();

}
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");
        builder.HasMany(p => p.Addresses)
               .WithOne(p => p.User)
               .HasForeignKey(p => p.userId)
               .OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.Comments)
               .WithOne(p => p.User)
               .HasForeignKey(p => p.UserId)
               .OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.ShoppedOrders)
               .WithOne(p => p.User)
               .HasForeignKey(p => p.userId)
               .OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.SelectedProducts)
               .WithOne(p => p.User)
               .HasForeignKey(p => p.userId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}