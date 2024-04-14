using Microsoft.EntityFrameworkCore;
using SportApp.ProductsServices.Api.Middleware;
using SportApp.ProductsServices.Application;
using SportApp.ProductsServices.Infrastructure;
using SportApp.ProductsServices.Infrastructure.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

    builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddMediatR();
    builder.Services.AddInfrastructureServices(builder.Configuration);
    builder.Services.AddApplicationServices();
    builder.Services.AddCors(
        options =>
        {
            options.AddPolicy
                (
                    "CorsPolicy",
                    builder =>
                        builder.AllowAnyOrigin()
                            .AllowAnyMethod().
                            AllowAnyHeader()
                );
        }
        );
    var app = builder.Build();
// Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseMiddleware<ExceptionMiddleware>();
    app.UseHttpsRedirection();
    app.UseCors("CorsPolicy");
    app.UseAuthorization();
    app.MapControllers();
    ApplyMigration();
    app.MapGet("/", () => "Working fine!");
    app.Run();
    void ApplyMigration()
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<ProductServiceContext>();
        if (db.Database.GetPendingMigrations().Any())
        {
            db.Database.Migrate();
        }
    }
