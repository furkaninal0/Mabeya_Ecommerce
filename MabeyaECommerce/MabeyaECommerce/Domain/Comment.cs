using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;  

namespace MabeyaECommerce.Domain;

public class Comment
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }

    public required string Text { get; set; }
    public DateTime Date { get; set; }
    public Product? Product { get; set; }
    public User? User { get; set; }
}

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder
              .ToTable("Comment");
        builder
            .HasIndex(p => new { p.Date })
            .IsUnique(true);
           

    }
}

