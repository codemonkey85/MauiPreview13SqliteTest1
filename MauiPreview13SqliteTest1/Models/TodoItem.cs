using System.ComponentModel.DataAnnotations;

namespace MauiPreview13SqliteTest1.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsComplete { get; set; }
    }
}
