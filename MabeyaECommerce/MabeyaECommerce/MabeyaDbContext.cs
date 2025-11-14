using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;

namespace MabeyaECommerce;

public class MabeyaDbContext (DbContextOptions options): IdentityDbContext<
    User,
    Role,
    Guid>(options)

{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(MabeyaDbContext).Assembly);
    }
    public required DbSet<Address> Addresses { get; set; }
    public required DbSet<Catalog> Catalogs{ get; set; }
    public required DbSet<CreditCard> CreditCards { get; set; }
    public required DbSet<ShoppingCartItem> shoppingCartItems { get; set; }

    public required DbSet<Category> Categories { get; set; }
    public required DbSet<City> Cities{ get; set; }
    public required DbSet<Comment> Comments { get; set; }
    public required DbSet<Product> Products { get; set; }
    public required DbSet<ProductDetails> ProductDetails{ get; set; }
    public required DbSet<ProductImages> ProductImages{ get; set; }
    public required DbSet<Province> Provinces { get; set; }
    public required DbSet<ShoppedOrder> shoppedOrders{ get; set; }
    public required DbSet<ShoppedOrder_Item> shoppedOrder_Items{ get; set; }
    public required DbSet<SliderImage> sliderImages{ get; set; }
    public required DbSet<Spec> Specs{ get; set; }
    public DbSet<VisitLog> VisitLogs { get; set; }



}


