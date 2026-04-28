using ASP.NETCoreAPI.Models;

namespace ASP.NETCoreAPI.Services
{
    public interface IPersonServices
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        bool Delete(long id);

    }
}
