using Schebeautyshop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<SchebeautyshopContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DbSchebeautyshop"))
);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var Context = scope.ServiceProvider.GetRequiredService<SchebeautyshopContext>();
    Context.Database.Migrate(); 

}

DatabaseInitializer.Seed(app);


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




