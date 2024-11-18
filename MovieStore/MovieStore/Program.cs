using Mapster;
using MovieStore.BL;
using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;
using MovieStore.MasterConfig;

namespace MovieStore
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .RegisterDataLayer()
                .RegisterBusinessLayer();
            builder.Services.AddMapster();
            MapsterConfiguration.Configure();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
