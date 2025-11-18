namespace MabeyaECommerce.Domain;

public class Subscriber
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.Now;

}
