using Microsoft.EntityFrameworkCore;
using RazorPagesEFCoreFilterDemo.Data;
using RazorPagesEFCoreFilterDemo.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IZooRepository, ZooRepository>();

var connectionString =
    builder.Configuration.GetConnectionString("Zoo")
        ?? throw new InvalidOperationException("Connection string 'Zoo' not found.");

builder.Services.AddDbContext<ZooContext>(options =>
    options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddRazorPages();

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
