using ESTACIONAMIENTO_D.Data;
using ESTACIONAMIENTO_D.Models;
using Microsoft.EntityFrameworkCore;

namespace ESTACIONAMIENTO_D
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            

            




            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<EstacionamientoContext>(options => options.UseInMemoryDatabase("EstacionamientoDB"));


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
        }
   

    }
}