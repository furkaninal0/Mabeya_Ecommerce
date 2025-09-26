using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MabeyaECommerce;

public class MabeyaDbContext (DbContextOptions options): IdentityDbContext<
    User,
    Role,
    Guid,
    IdentityUserClaim<Guid>,
    IdentityUserRole<Guid>,
    IdentityUserLogin<Guid>,
    IdentityRoleClaim<Guid>,
    IdentityUserToken<Guid>>(options)

{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(MabeyaDbContext).Assembly);
    }
    public required DbSet<Category> Categories { get; set; }
    public required DbSet<Product> Products { get; set; }
    public required DbSet<Comment> Comments { get; set; }


}
