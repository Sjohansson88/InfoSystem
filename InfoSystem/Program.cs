using InfoSystem.Data;
using InfoSystem.Models;
using InfoSystem.Service;
using Microsoft.EntityFrameworkCore;

namespace InfoSystem
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);


			builder.Services.AddDbContext<AppDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"));
			});


            builder.Services.AddScoped<IDriverRepository, DriverRepository>();
			builder.Services.AddScoped<IEventRepository, EventRepository>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();


            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); 
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

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
            app.UseSession();
            app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Account}/{action=Login}/{id?}");

			app.Run();
		}
	}
}
