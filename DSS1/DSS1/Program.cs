using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DSS1.Data;
using AssignmentDSS;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DSS1IdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'DSS1IdentityContextConnection' not found.");

builder.Services.AddDbContext<DSS1IdentityContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DSS1IdentityContext>();;
builder.Services.AddDbContext<DSS1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DSS1Context") ?? throw new InvalidOperationException("Connection string 'DSS1Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
    //var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

    Seed.Initialize(services);
    //Seed.SeedRoles(roleManager);
    Seed.SeedAdmin(userManager);

}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
