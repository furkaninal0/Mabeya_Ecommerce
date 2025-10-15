using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MabeyaECommerce.Domain;

public class SliderImage 
{
    public Guid Id { get; set; }
    public Guid userId { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsEnabled { get; set; }
    public byte[] Image{ get; set; }
    public Guid catalogId { get; set; }



}
public class SliderImageConfiguration : IEntityTypeConfiguration<SliderImage>
{
    public void Configure(EntityTypeBuilder<SliderImage> builder)
    {
        //tpt
        builder.ToTable("SliderImages");

        builder.Property(p => p.Image)
            .IsRequired();

    }

}