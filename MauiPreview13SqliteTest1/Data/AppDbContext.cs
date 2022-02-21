using MauiPreview13SqliteTest1.Models;
using Microsoft.EntityFrameworkCore;

namespace MauiPreview13SqliteTest1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public virtual DbSet<TodoItem> TodoItems { get; set; }
    }
}
