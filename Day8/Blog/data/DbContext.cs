using Microsoft.EntityFrameworkCore;
using PostgresDb.Models;

public class PgDbContext : DbContext
{
    public DbSet<User> User { get; set; }
    public DbSet<Blog_> Blogs { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure your PostgreSQL connection string
        string connectionString = "Host=localhost;Database=blog;Username=admin;Password=12345678";
        optionsBuilder.UseNpgsql(connectionString);
    }
}
