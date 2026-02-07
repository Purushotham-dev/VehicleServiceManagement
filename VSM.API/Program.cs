using Microsoft.EntityFrameworkCore;
using VSM.Application.Interfaces;
using VSM.Application.Services;
using VSM.Infrastructure.Data;
using VSM.Infrastructure.Repositories;

namespace VSM.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IAuthenticateUser, AuthenticateService>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var config = builder.Configuration.GetConnectionString("DBConnect");
            builder.Services.AddDbContext<AppDBContext>(options =>
            options.UseSqlServer(config));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/openapi/v1.json", "Open API V1");
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
