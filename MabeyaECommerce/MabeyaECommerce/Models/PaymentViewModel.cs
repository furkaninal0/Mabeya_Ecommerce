using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MabeyaECommerce.Models;

public class PaymentViewModel
{
    [JsonPropertyName("shippingAddressId")]
    public Guid ShippingAddressId { get; set; }

    [JsonPropertyName("billingAddressId")]
    public Guid BillingAddressId { get; set; }

    [JsonPropertyName("cardNumber")]
    public string? CardNumber { get; set; }

    [JsonPropertyName("cardHolderName")]
    public string? CardHolderName { get; set; }

    [JsonPropertyName("cvc")]
    public string? Cvc { get; set; }

    [JsonPropertyName("expireMonth")]
    public int ExpireMonth { get; set; }

    [JsonPropertyName("expireYear")]
    public int ExpireYear { get; set; }
}
