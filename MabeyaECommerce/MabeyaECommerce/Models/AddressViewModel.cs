using System.ComponentModel.DataAnnotations;

namespace MabeyaECommerce.Models;

public class AddressViewModel
{
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
    public string? Name { get; set; }
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
    public string? Text { get; set; }
    [DataType(DataType.PhoneNumber)]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
    public string? Number { get; set; }
    public string? zipCode { get; set; }
    public int CityId { get; set; }

}
