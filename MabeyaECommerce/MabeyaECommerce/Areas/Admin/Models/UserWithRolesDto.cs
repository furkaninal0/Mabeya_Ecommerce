using MabeyaECommerce.Domain;

namespace MabeyaECommerce.Areas.Admin.Models;

public class UserWithRolesDto
{

    public User User { get; set; }
    public List<string> Roles { get; set; }
    public bool IsEnabled { get; set; }

}
