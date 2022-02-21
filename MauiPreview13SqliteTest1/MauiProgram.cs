using MauiPreview13SqliteTest1.Data;
using Microsoft.EntityFrameworkCore;

namespace MauiPreview13SqliteTest1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        const string connectionString = @"Data Source=data.db;";

        //builder.Services.AddDbContext<AppDbContext>(); // (options => options.UseSqlite(connectionString));
        builder.Services.AddDbContextFactory<AppDbContext>(options => options.UseSqlite(connectionString));

        var app = builder.Build();

        var dbContext = app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();
        dbContext.Database.EnsureCreated();

        return app;
    }
}
