using MauiPreview13SqliteTest1.Services;

namespace MauiPreview13SqliteTest1;

public partial class App : Application
{
    public App(TodoService todoService)
    {
        InitializeComponent();
        MainPage = new MainPage(todoService);
    }
}
