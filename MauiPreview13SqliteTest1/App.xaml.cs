using MauiPreview13SqliteTest1.Data;

namespace MauiPreview13SqliteTest1;

public partial class App : Application
{
    public App(AppDbContext dbContext)
    {
        InitializeComponent();
        MainPage = new MainPage(dbContext);
    }
}
