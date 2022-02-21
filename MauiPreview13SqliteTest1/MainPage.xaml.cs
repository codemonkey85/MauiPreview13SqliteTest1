using MauiPreview13SqliteTest1.Data;

namespace MauiPreview13SqliteTest1;

public partial class MainPage : ContentPage
{
    private AppDbContext _dbContext;
    public MainPage(AppDbContext dbContext)
    {
        InitializeComponent();
        _dbContext = dbContext;
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        var TodoItem = _dbContext.TodoItems.FirstOrDefault();
        ResultsLabel.Text = TodoItem?.Title ?? "Todo not found!";
    }
}

