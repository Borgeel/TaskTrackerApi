using System.ComponentModel.DataAnnotations;

namespace TaskTrackerApi.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateOnly Date { get; set; } = new DateOnly();
        public bool Reminder { get; set; }
    }
}
