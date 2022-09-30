using Microsoft.EntityFrameworkCore;
using TaskTrackerApi.Models;
using Task = TaskTrackerApi.Models.Task;

namespace TaskTrackerApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
