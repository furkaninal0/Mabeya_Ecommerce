using Microsoft.AspNetCore.Identity;

namespace MabeyaECommerce.Domain;

public class User :IdentityUser<Guid>
{
    public required string givenName { get; set; }    
    public DateTime Date{ get; set; }
      

}
