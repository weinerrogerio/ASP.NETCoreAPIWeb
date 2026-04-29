using ASP.NETCoreAPI.Models;

namespace ASP.NETCoreAPI.Repositories
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll(int page, int pageSize);
        Person Update(Person person);
        bool Delete(long id);
    }
}
