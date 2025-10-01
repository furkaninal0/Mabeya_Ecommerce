using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class ShoppedOrder
{
    public Guid Id { get; set; }
    public Guid userId { get; set; }
    public Guid ShippingAddressId { get; set; }
    public DateTime Date { get; set; }
    public User? User { get; set; }

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

    }
}