using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Dto;

namespace ASP.NETCoreAPI.Services
{
    public interface IPersonServices
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll(int page, int pageSize);
        Person Update(UpdatePersonDto person);
        void Delete(long id);

    }
}
