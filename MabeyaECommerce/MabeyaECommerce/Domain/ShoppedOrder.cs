using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class ShoppedOrder
{
    public Guid Id { get; set; }
    public Guid userId { get; set; }
    public Guid addressId { get; set; }
    public DateTime Date { get; set; }
    public User? User { get; set; } = null!;
    public Address? Address { get; set; } = null!;

    public ICollection<ShoppedOrder_Item> Order_Items { get; set; } = new List<ShoppedOrder_Item>();
}

public class ShoppedOrderConfiguration : IEntityTypeConfiguration<ShoppedOrder>
{
    public void Configure(EntityTypeBuilder<ShoppedOrder> builder)
    {
        builder.ToTable("ShoppedOrders");

       builder.HasMany(p=>p.Order_Items)
              .WithOne(p=>p.ShoppedOrder)
              .HasForeignKey(p=>p.shoppedOrderId)
              .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(o => o.Address)
       .WithMany()
       .HasForeignKey(o => o.addressId)
       .IsRequired()
       .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(o => o.User)
       .WithMany()
       .HasForeignKey(o => o.userId)
       .IsRequired()
       .OnDelete(DeleteBehavior.Restrict);
      

    }
}