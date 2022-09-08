using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UCTprojecthub.Areas.Identity.Data;
using UCTprojecthub.Data;
using UCTprojecthub.IRepository;
using UCTprojecthub.Repository;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("UCTprojecthubContextConnection") ?? throw new InvalidOperationException("Connection string 'UCTprojecthubContextConnection' not found.");

builder.Services.AddDbContext<UCTprojecthubContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<UCTprojecthubUser>(options =>
    {
        options.Password.RequireNonAlphanumeric = false;
        options.SignIn.RequireConfirmedEmail = false;
        options.SignIn.RequireConfirmedAccount = false;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<UCTprojecthubContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI();

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});




builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
});

builder.Services.AddScoped<iUserRepository, userRepository>();
builder.Services.AddScoped<iUnitOfWork, UnitOfWork>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();



app.Run();
