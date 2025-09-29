using MabeyaECommerce;
using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MabeyaDbContext>(config =>
    { config.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
    });

builder
    .Services.AddIdentity<User, Role>(config =>
    {
    config.Password.RequireDigit = builder.Configuration.GetValue<bool>("Identity:RequireDigit");
    config.Password.RequireLowercase = builder.Configuration.GetValue<bool>("Identity:RequireLowercase");
    config.Password.RequireUppercase = builder.Configuration.GetValue<bool>("Identity:RequireUppercase");
    config.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:RequireNonAlphanumeric");
    config.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:RequiredLength");
    config.Password.RequiredUniqueChars = builder.Configuration.GetValue<int>("Identity:RequiredUniqueChars");

    config.User.RequireUniqueEmail = true;
    config.Lockout.MaxFailedAccessAttempts = 5;
    config.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    })
    .AddEntityFrameworkStores<MabeyaDbContext>();

builder.Services.AddAuthentication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();
var scope = app.Services.CreateScope();
var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();
var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
new[]
{
    new Role  {Name = "Administrators", givenName= "" },
    new Role  {Name = "Moderators", givenName= "" },
    new Role  {Name = "Members", givenName= "" },

}
.ToList()
.ForEach(role =>
 {
     if (!roleManager.RoleExistsAsync(role.Name).Result)
         roleManager.CreateAsync(role).Wait();

 });
{
var user = new User()
{
    UserName = "mabeya@9895.com",
    givenName = "Karataþ",
    Email = "mabeya@9895.com",
    EmailConfirmed= true,
    Date = DateTime.Now,
};
    userManager.CreateAsync(user).Wait();
    userManager.AddClaimAsync(user, new Claim(ClaimTypes.GivenName, "Karataþ")).Wait();
    userManager.AddToRoleAsync(user, "Administrators").Wait();
}

   
app.Run();
