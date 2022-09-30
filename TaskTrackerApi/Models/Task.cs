using System.ComponentModel.DataAnnotations;

namespace TaskTrackerApi.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public new DateTime Date { get; set; }
        public bool Reminder { get; set; }
    }
}
