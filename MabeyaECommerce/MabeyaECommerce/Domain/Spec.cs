namespace MabeyaECommerce.Domain;

public class Spec : _EntityBase
{
    public string Name { get; set; }
    public Guid? categoryId { get; set; }
    public Category? Category { get; set; }

}
