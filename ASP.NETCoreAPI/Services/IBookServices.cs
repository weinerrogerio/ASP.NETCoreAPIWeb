using ASP.NETCoreAPI.Data.DTO;
using ASP.NETCoreAPI.Models;

namespace ASP.NETCoreAPI.Services
{
    public interface IBookServices
    {
        BookDTO Create(BookDTO book);
        BookDTO FindById(long id);
        List<BookDTO> FindAll(int page, int pageSize);
        BookDTO Update(UpdateBooksDto book);
        void Delete(long id);
    }
}
