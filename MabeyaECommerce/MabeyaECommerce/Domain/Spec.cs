namespace MabeyaECommerce.Domain;

public class Spec 
{
    public Guid Id { get; set; }
    public Guid userId { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsEnabled { get; set; }
    public string Name { get; set; }
    public Guid? categoryId { get; set; }
    public Category? Category { get; set; }

}
