using MabeyaECommerce.Domain;

namespace MabeyaECommerce.Areas.Admin.Models;

public class UserDetailViewModel
{
    public User User { get; set; }

    public List<Address> ShippingAddresses { get; set; }
    public List<Address> BillingAddresses { get; set; }

    public List<ShoppedOrder> Orders { get; set; }

}
