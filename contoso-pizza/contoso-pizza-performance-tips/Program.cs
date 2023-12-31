using contoso_pizza_performance_tips.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContextPool<ContosoPizzaContext>(options => // tip: use the pool version of adding a db context to reuse it over and over again
    options
        .UseLazyLoadingProxies() // tip: lazy loding, added a new nuget package also
        .UseSqlServer(builder.Configuration.GetConnectionString("ContosoPizza")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
