using Microsoft.EntityFrameworkCore;

public class VidhyalayaDbContext: DbContext
{
    
    public DbSet<Grade> Grade { get; set; }
    public DbSet<Student> Student  { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlite("Data Source=Vidhyalaya.db");
    }
}