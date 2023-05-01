using Api.Contexto;
using CursoMvc.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<LasTablas>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("conexcion"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapGet("/res", async () => 
{
HttpClient cliente = new HttpClient();
    var repuesta = await cliente.GetAsync("https://rickandmortyapi.com/api/character");
    repuesta.EnsureSuccessStatusCode();
    string rep = await repuesta.Content.ReadAsStringAsync();

    return rep;

});



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
