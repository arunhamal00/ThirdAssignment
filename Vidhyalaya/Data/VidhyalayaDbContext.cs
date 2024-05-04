using Microsoft.EntityFrameworkCore;

public class VidhyalayaDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=collegeMonitor.db");
    }
}