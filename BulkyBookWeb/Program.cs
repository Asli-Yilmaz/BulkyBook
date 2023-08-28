using BulkyBookWeb.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//for hot loading
;

builder.Services.AddDbContext<ApplicationDBContex>(options=>options.UseNpgsql(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
builder.Services.AddRazorPages();
var app = builder.Build();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//bu bir middleware
app.UseHttpsRedirection();

//bu da bir middleware
app.UseStaticFiles();

app.UseRouting();
//e�er authentication i�lemi yapmak istersen authorizationdan �nce yapmal�s�n sonr ayaparsan hata verir
//app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
//burada middleware'lerin s�ralamas� �ok �nemli yal�� s�ralamada �al��ma hatas� al�rs�n
