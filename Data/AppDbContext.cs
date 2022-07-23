using Microsoft.EntityFrameworkCore;
using commandsAPI.Models;

namespace commandsAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Command> Commands => Set<Command>();

    }
}