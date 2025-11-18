using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class OrderCancellation
{
    public Guid Id { get; set; }
    public Guid ShoppedOrderId { get; set; }
    public ShoppedOrder? Order { get; set; }
    public Guid? UserId { get; set; }
    public User? User { get; set; }
    public string? Reason { get; set; }
    public DateTime CancelledAt { get; set; } = DateTime.Now;


}
public class OrderCancellationConfiguration : IEntityTypeConfiguration<OrderCancellation>
{
    public void Configure(EntityTypeBuilder<OrderCancellation> builder)
    {
        builder.ToTable("OrderCancellations");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Reason)
               .HasMaxLength(500);

        builder.HasOne(p => p.Order)
               .WithMany(p => p.Cancellations)
               .HasForeignKey(p => p.ShoppedOrderId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.User)
               .WithMany()
               .HasForeignKey(p => p.UserId)
               .OnDelete(DeleteBehavior.SetNull);
    }
}