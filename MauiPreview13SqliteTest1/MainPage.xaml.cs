using System.Collections.ObjectModel;
using MauiPreview13SqliteTest1.Models;
using MauiPreview13SqliteTest1.Services;

namespace MauiPreview13SqliteTest1;

public partial class MainPage : ContentPage
{
    private TodoService _todoService;

    public ObservableCollection<TodoItem> TodoItems { get; set; } = new();

    public MainPage(TodoService todoService)
    {
        InitializeComponent();
        _todoService = todoService;
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        if (!TodoItems.Any())
        {
            foreach (var todo in await _todoService.GetAllTodoItemsAsync())
            {
                TodoItems.Add(todo);
            }
            TodosListView.ItemsSource = TodoItems;
        }
    }
}
