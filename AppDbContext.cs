using DockerSqlServer2.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerSqlServer2
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
