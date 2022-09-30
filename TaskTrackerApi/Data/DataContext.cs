using Microsoft.EntityFrameworkCore;

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
