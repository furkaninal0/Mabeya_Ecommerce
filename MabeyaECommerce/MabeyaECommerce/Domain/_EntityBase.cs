namespace MabeyaECommerce.Domain;

public class _EntityBase
{
    public Guid Id { get; set; }
    public Guid userId { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsEnabled { get; set; } 



}
