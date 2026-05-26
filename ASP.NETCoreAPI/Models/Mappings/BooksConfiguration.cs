using ASP.NETCoreAPI.Models.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP.NETCoreAPI.Models.Mappings
{
    public class BooksConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            // Regras da tabela
            builder.ToTable("book");
            builder.HasKey(b => b.Id);

            // População: chama a classe de dados
            builder.HasData(BookSeed.GetPredefinedBooks());


        }       
    }
}
