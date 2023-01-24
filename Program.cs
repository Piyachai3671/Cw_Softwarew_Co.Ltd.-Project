using CW_ordermedicine.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using CW_ordermedicine.Data.Services;
using Microsoft.EntityFrameworkCore;
using Radzen;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
   
        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddScoped<GroupMemberService>();
        builder.Services.AddScoped<ReportService>();
        builder.Services.AddScoped<UserService>();
        builder.Services.AddScoped<ProductService>();
        builder.Services.AddSingleton<CartProductService>();
        builder.Services.AddScoped<LoginService>();
		builder.Services.AddScoped<OrderService>();
		builder.Services.AddScoped<OrderItemService>();
		builder.Services.AddScoped<NotificationService>();
		builder.Services.AddScoped<ImgService>();
		builder.Services.AddDbContext<ApplicationContext>(i => i.UseSqlServer("Server=.\\SQLEXPRESS;Database=CwOrderMedicDataBase;Trusted_Connection=True;Encrypt=true;TrustServerCertificate=true; "));



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

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }
}