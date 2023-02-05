using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TEMA_MEDII_ROCA_RARES_GEORGE.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<TEMA_MEDII_ROCA_RARES_GEORGEContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TEMA_MEDII_ROCA_RARES_GEORGEContext") ?? throw new InvalidOperationException("Connection string 'TEMA_MEDII_ROCA_RARES_GEORGEContext' not found.")));

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
