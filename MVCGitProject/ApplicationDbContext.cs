using Microsoft.EntityFrameworkCore;
using MVCGitProject.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<lessons> lessons { get; set; } 
    public DbSet<users> users { get; set; }
}