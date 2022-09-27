using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AssignmentDSS.Data;
using AssignmentDSS;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AssignmentDSSIdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'AssignmentDSSIdentityContextConnection' not found.");

builder.Services.AddDbContext<AssignmentDSSIdentityContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AssignmentDSSIdentityContext>();;
builder.Services.AddDbContext<AssignmentDSSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AssignmentDSSContext") ?? throw new InvalidOperationException("Connection string 'AssignmentDSSContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

    Seed.Initialize(services);
    Seed.SeedRoles(roleManager);
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
