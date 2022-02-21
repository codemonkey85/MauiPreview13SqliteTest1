using System.Collections.ObjectModel;
using MauiPreview13SqliteTest1.Data;
using MauiPreview13SqliteTest1.Models;

namespace MauiPreview13SqliteTest1;

public partial class MainPage : ContentPage
{
    private AppDbContext _dbContext;

    public ObservableCollection<TodoItem> TodoItems { get; set; } = new();

    public MainPage(AppDbContext dbContext)
    {
        InitializeComponent();
        _dbContext = dbContext;
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        if (!TodoItems.Any())
        {
            foreach (var todo in _dbContext.TodoItems.ToArray())
            {
                TodoItems.Add(todo);
            }
            TodosListView.ItemsSource = TodoItems;
        }
    }
}
