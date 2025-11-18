using MabeyaECommerce;
using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;
using System.Security.Claims;
using MabeyaECommerce.Middlewares;
using DinkToPdf;
using DinkToPdf.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MabeyaDbContext>(config =>
{
    config.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
    
});


builder
    .Services.AddIdentity<User, Role>(config =>
    {
        config.Password.RequireDigit = builder.Configuration.GetValue<bool>("PasswordPolicy:RequireDigit");
        config.Password.RequireLowercase = builder.Configuration.GetValue<bool>("PasswordPolicy:RequireLowercase");
        config.Password.RequireUppercase = builder.Configuration.GetValue<bool>("PasswordPolicy:RequireUppercase");
        config.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("PasswordPolicy:RequireNonAlphanumeric");
        config.Password.RequiredLength = builder.Configuration.GetValue<int>("PasswordPolicy:RequiredLength");
        config.Password.RequiredUniqueChars = builder.Configuration.GetValue<int>("PasswordPolicy:RequiredUniqueChars");

        config.User.RequireUniqueEmail = true;
    config.Lockout.MaxFailedAccessAttempts = 5;
    config.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    })
    .AddEntityFrameworkStores<MabeyaDbContext>()
    .AddDefaultTokenProviders();
builder.Services
    .AddControllersWithViews()
    .AddJsonOptions(o =>
    {
        o.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    });
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = SameSiteMode.None;
    options.Secure = CookieSecurePolicy.Always;
});
builder.Services.AddAntiforgery(options =>
{
    options.Cookie.SameSite = SameSiteMode.None;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
});
builder.Services.ConfigureApplicationCookie(options =>
{
options.Cookie.SameSite = SameSiteMode.None;
options.Cookie.SecurePolicy = CookieSecurePolicy.Always;

options.LoginPath = "/Account/Login";
});
builder.Services.AddMailKit(option =>
{
    option.UseMailKit(new MailKitOptions()
    {
        Server = builder.Configuration["EmailSettings:Server"],
        Port = builder.Configuration.GetValue<int>("EmailSettings:Port"),
        SenderName = builder.Configuration["EmailSettings:SenderName"],
        SenderEmail = builder.Configuration["EmailSettings:SenderEmail"],
        Account = builder.Configuration["EmailSettings:UserName"],
        Password = builder.Configuration["EmailSettings:Password"],
        Security = builder.Configuration.GetValue<bool>("EmailSettings:Security")
    });
});


builder.Services.AddAuthentication();
builder.Services.AddSession();


var app = builder.Build();
app.UseStaticFiles();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseCookiePolicy();

app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<VisitTrackingMiddleware>();

app.MapStaticAssets();
app.MapControllerRoute(
    name: "Catalog",
    pattern: "{name}-catalog-{id}",
    defaults: new { controller = "Home", action = "Catalog" });
app.MapControllerRoute(
    name: "Category",
    pattern: "{name}-category-{id}",
    defaults: new { controller = "Home", action = "Category" });
app.MapControllerRoute(
    name: "Product",
    pattern: "{name}-product-{id}",
    defaults: new { controller = "Home", action = "Detail" });
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    

var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<MabeyaDbContext>();
var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();
var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
dbContext.Database.Migrate();

new[]
{
    new Role  {givenName="Yönetici " , Name = "Administrators", },
    new Role  {givenName="Yönetici Yardımcısı" , Name = "Moderators", },
    new Role  {givenName="Üyeler" , Name = "Members", },

}
.ToList()
.ForEach(p =>
 {
         roleManager.CreateAsync(p).Wait();

 });

var user = new User()
{
    Date = DateTime.Now,
    givenName = "Karataş",
    UserName = "mabeya@9895.com",
    Email = "mabeya@9895.com",
    EmailConfirmed= true,
    SecurityStamp = Guid.NewGuid().ToString()   

};
    userManager.CreateAsync(user , "19941998esbey").Wait();
    userManager.AddToRoleAsync(user, "Administrators").Wait();
    userManager.AddClaimAsync(user, new Claim(ClaimTypes.GivenName, user.givenName)).Wait();

app.Run();
