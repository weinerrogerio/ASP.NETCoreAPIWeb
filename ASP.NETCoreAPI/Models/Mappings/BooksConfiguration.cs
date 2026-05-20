using ASP.NETCoreAPI.Models.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP.NETCoreAPI.Models.Mappings
{
    public class BooksConfiguration : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            // Regras da tabela
            builder.ToTable("books");
            builder.HasKey(b => b.Id);

            // População: chama a classe de dados
            builder.HasData(BookSeed.GetPredefinedBooks());
        }       
    }
}
