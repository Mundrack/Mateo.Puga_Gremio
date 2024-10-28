using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mateo.Puga_Examen_Progreso_I.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MateoPuga_Examen_Progreso_IContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MateoPuga_Examen_Progreso_IContext") ?? throw new InvalidOperationException("Connection string 'MateoPuga_Examen_Progreso_IContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
