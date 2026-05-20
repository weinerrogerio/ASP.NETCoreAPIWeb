using ASP.NETCoreAPI.Models;

namespace ASP.NETCoreAPI.Services
{
    public interface IBookServices
    {
        Books Create(Books book);
        Books FindById(long id);
        List<Books> FindAll(int page, int pageSize);
        Books Update(UpdateBooksDto book);
        bool Delete(long id);
    }
}
