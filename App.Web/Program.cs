using App.Web.Models.Repositories;
using App.Web.Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Singleton
//builder.Services.AddSingleton<ProductRepository>();
// Transient
//builder.Services.AddTransient<ProductRepository>();
// Scoped
builder.Services.AddScoped<IProductRepository,ProductRepository>();







var app = builder.Build();

// Dependency Injection  DI Container framework / Inversion Of Control Container



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
