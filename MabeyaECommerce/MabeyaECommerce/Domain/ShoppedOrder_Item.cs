using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace MabeyaECommerce.Domain;

public class ShoppedOrder_Item
{

    public Guid Id { get; set; }
    public Guid productId { get; set; }
    public Guid shoppedOrderId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public Product? Product { get; set; }
    public ShoppedOrder? ShoppedOrder { get; set; }
    [NotMapped]
    public decimal Amount => Price * Quantity;


}
public class ShoppedOrder_ItemConfiguration : IEntityTypeConfiguration<ShoppedOrder_Item>
{
    public void Configure(EntityTypeBuilder<ShoppedOrder_Item> builder)
    {
        //tpt
        builder.ToTable("ShoppedOrder_Items");

        builder.Property(p => p.Price)
            .IsRequired();

    }

}