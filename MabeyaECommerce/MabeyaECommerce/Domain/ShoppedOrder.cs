using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace MabeyaECommerce.Domain;

public enum OrderStatus
{
    New, InProgress, Shipped, Delivered, Cancelled
}

public class ShoppedOrder
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public Guid? ShippingAddressId { get; set; }
    public Address? ShippingAddress { get; set; }

    public Guid? BillingAddressId { get; set; }
    public Address? BillingAddress { get; set; }
  

    public DateTime Date { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.New;
    public string? ShippingNumber { get; set; }

    public string? TrackingNumber { get; set; }
    public string? ReturnTrackingNumber { get; set; }
    public string? UserReturnTrackingNumber { get; set; }


    public bool IsReturnRequested { get; set; } = false;
    public bool IsReturnApproved { get; set; } = false;

    public bool FinalReturnApproved { get; set; } = false;
    public DateTime? ReturnCompletedDate { get; set; }


    [NotMapped]
    public decimal GrandTotal => Order_Items.Sum(p => p.Amount);

    public ICollection<ShoppedOrder_Item> Order_Items { get; set; } = new List<ShoppedOrder_Item>();
    public ICollection<OrderCancellation> Cancellations { get; set; } = new List<OrderCancellation>();

}

public class ShoppedOrderConfiguration : IEntityTypeConfiguration<ShoppedOrder>
{
    public void Configure(EntityTypeBuilder<ShoppedOrder> builder)
    {
        builder.ToTable("ShoppedOrders");

        builder.HasMany(p => p.Order_Items)
               .WithOne(p => p.ShoppedOrder)
               .HasForeignKey(p => p.shoppedOrderId)
               .OnDelete(DeleteBehavior.Restrict);

        // ✅ Teslimat adresi
        builder.HasOne(o => o.ShippingAddress)
               .WithMany()
               .HasForeignKey(o => o.ShippingAddressId)
               .OnDelete(DeleteBehavior.Restrict);

        // ✅ Fatura adresi
        builder.HasOne(o => o.BillingAddress)
               .WithMany()
               .HasForeignKey(o => o.BillingAddressId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.User)
               .WithMany()
               .HasForeignKey(o => o.UserId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
