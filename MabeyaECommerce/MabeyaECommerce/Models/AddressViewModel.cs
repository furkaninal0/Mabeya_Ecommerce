using System.ComponentModel.DataAnnotations;

namespace MabeyaECommerce.Models;

public class AddressViewModel
{

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Text { get; set; }

    [Required]
    public string? Number { get; set; }

    [Required]
    public string? zipCode { get; set; }

    [Required]
    public int CityId { get; set; }

    public bool IsInvoice { get; set; }
    public bool IsShipping { get; set; }

    public string? TaxNumber { get; set; }
    public string? TaxOffice { get; set; }
}
