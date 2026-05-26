using ASP.NETCoreAPI.Models.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreAPI.Models.Context
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Book> Books { get; set; }

        // Configurações adicionais para o modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configurações para a entidade Books - mapeamento para a tabela "Books" (populando dados iniciais)
            modelBuilder.ApplyConfiguration(new BooksConfiguration());
        }
    }
}
