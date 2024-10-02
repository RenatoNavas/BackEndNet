using BackEndNet.Data;
using Microsoft.EntityFrameworkCore;

namespace BackEndNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<AppDbContext>(o =>
            {
                o.UseNpgsql(builder.Configuration.GetConnectionString("StoreDatabase"));
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            //Prueba commit

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
