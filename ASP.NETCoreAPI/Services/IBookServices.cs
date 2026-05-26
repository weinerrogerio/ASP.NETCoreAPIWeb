using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Dto;

namespace ASP.NETCoreAPI.Services
{
    public interface IBookServices
    {
        Book Create(Book book);
        Book FindById(long id);
        List<Book> FindAll(int page, int pageSize);
        Book Update(UpdateBooksDto book);
        void Delete(long id);
    }
}
