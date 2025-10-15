using MabeyaECommerce;
using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MabeyaDbContext>(config =>
{
    config.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
    
});


//AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
//config.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
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
    .AddEntityFrameworkStores<MabeyaDbContext>()
    .AddDefaultTokenProviders();
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
builder
    .Services
    .AddMailKit(config =>
    {
        config.UseMailKit(new MailKitOptions
        {
            Server = "sandbox.smtp.mailtrap.io",
            Port = 2525,
            SenderName = "MVCEcommerce Hesap",
            SenderEmail = "hesap@mvcforum.com",
            Account = "1dbd08a42eee36",
            Password = "94db0de79ecb1e",
            Security = true,



        });
    });


builder.Services.AddAuthentication();

var app = builder.Build();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseCookiePolicy();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

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
    new Role  {givenName="Yönetici Yardýmcýsý" , Name = "Moderators", },
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
    givenName = "Karataþ",
    UserName = "mabeya@9895.com",
    Email = "mabeya@9895.com",
    EmailConfirmed= true,
};
    userManager.CreateAsync(user , "19941998esbey").Wait();
    userManager.AddToRoleAsync(user, "Administrators").Wait();
    userManager.AddClaimAsync(user, new Claim(ClaimTypes.GivenName, user.givenName)).Wait();

app.Run();
