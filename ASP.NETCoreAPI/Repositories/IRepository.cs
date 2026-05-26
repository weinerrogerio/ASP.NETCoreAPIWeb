using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Base;

namespace ASP.NETCoreAPI.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> FindAll(int page, int pageSize);
        T FindById(long id);
        T Create(T item);        
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}
