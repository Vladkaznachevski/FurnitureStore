using Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository.OrderRepo;
using Repository.ShopCartRepo;
using Repository;
using Services.OrderSer;
using Repository.CategoryRepo;
using Services.CategorySer;
using Repository.ManufactoryRepo;
using Services.ManufactorySer;
using Repository.ProductRepo;
using Services.ProductSer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));


builder.Services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
builder.Services.AddTransient<ICategoryService, CategoryService>();

builder.Services.AddScoped(typeof(IManufactoryRepository), typeof(ManufactoryRepository));
builder.Services.AddTransient<IManufactoryService, ManufactoryService>();

builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
builder.Services.AddTransient<IProductService, ProductService>();

builder.Services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
builder.Services.AddTransient<IOrderService, OrderService>();

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => ShopCartRepository.GetCart(sp));
builder.Services.AddMemoryCache();
builder.Services.AddSession();
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
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
