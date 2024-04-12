using Microsoft.EntityFrameworkCore;
using XTracker.Models.ToDo;

public class AppToDoDbContext : DbContext
{
    public AppToDoDbContext(DbContextOptions <AppToDoDbContext> options) : base(options) { }
	
    public DbSet<Tasks> Tasks { get; set; }
}
