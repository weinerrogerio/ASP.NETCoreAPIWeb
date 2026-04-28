using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreAPI.Models.Context
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
