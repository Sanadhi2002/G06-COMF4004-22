using Microsoft.EntityFrameworkCore;
using Project_G06.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WebsiteAdminRegDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("WebsiteAdminConnectionString")));


builder.Services.AddDbContext<StudentEmailDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("StudentEmailsConnectionString")));


builder.Services.AddDbContext<UniProfileDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("UniProfileConnection")
    ));


builder.Services.AddDbContext<UniversitiesDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("UniversityConnectionString")));



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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
