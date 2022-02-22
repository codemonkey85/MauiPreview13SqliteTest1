using MauiPreview13SqliteTest1.Data;
using MauiPreview13SqliteTest1.Models;
using Microsoft.EntityFrameworkCore;

namespace MauiPreview13SqliteTest1.Services
{
    public class TodoService
    {
        private AppDbContext _appDbContext;

        public TodoService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<TodoItem[]> GetAllTodoItemsAsync()
        {
            return await _appDbContext.TodoItems.ToArrayAsync();
        }

        public async Task<TodoItem> CreateTodoItemAsync(TodoItem todoItem)
        {
            await _appDbContext.TodoItems.AddAsync(todoItem);
            await _appDbContext.SaveChangesAsync();
            return todoItem;
        }

        public async Task<TodoItem> GetTodoItemAsync(long id)
        {
            return await _appDbContext.TodoItems.FindAsync(id);
        }

        public async Task<TodoItem> UpdateTodoItemAsync(TodoItem todoItem)
        {
            _appDbContext.Entry(todoItem).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
            return todoItem;
        }

        public async void DeleteTodoItemAsync(long id)
        {
            var todoItem = await _appDbContext.TodoItems.FindAsync(id);
            _appDbContext.TodoItems.Remove(todoItem);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
