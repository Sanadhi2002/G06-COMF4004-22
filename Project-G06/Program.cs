using Microsoft.EntityFrameworkCore;
using Project_G06.Data;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WebsiteAdminRegDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("WebsiteAdminConnectionString")));

/*builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<WebAdminDbContext>();*/

builder.Services.AddDbContext<WebAdminDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("WebAdminConnectionString")));

builder.Services.AddDbContext<StudentEmailDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("StudentEmailsConnectionString")));


builder.Services.AddDbContext<UniProfileDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("UniProfileConnection")
    ));


builder.Services.AddDbContext<FacultyDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("FacultyConnectionString")
    ));




builder.Services.AddDbContext<UniversityDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection3")));
var app = builder.Build();

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

app.MapRazorPages();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

