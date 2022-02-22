using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MauiPreview13SqliteTest1.Models
{
    [Table("TodoItems")]
    public class TodoItem : INotifyPropertyChanged
    {
        private long id;
        private string title;
        private bool isCompleted;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [Key]
        [Column]
        public long Id { get => id; set { id = value; NotifyPropertyChanged(); } }

        [Column]
        public string Title { get => title; set { title = value; NotifyPropertyChanged(); } }

        [Column]
        public bool IsCompleted { get => isCompleted; set { isCompleted = value; NotifyPropertyChanged(); } }
    }
}
