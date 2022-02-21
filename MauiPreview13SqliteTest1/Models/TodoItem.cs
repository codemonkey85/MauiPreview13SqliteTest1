using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiPreview13SqliteTest1.Models
{
    [Table("TodoItems")]
    public class TodoItem
    {
        [Key]
        [Column]
        public int Id { get; set; }

        [Column]
        public string Title { get; set; }

        [Column]
        public bool IsCompleted { get; set; }
    }
}
