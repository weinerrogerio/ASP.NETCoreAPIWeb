using ASP.NETCoreAPI.Data.DTO;
using ASP.NETCoreAPI.Models;

namespace ASP.NETCoreAPI.Services
{
    public interface IPersonServices
    {
        PersonDTO Create(PersonDTO person);
        PersonDTO FindById(long id);
        List<PersonDTO> FindAll(int page, int pageSize);
        PersonDTO Update(UpdatePersonDto person);
        void Delete(long id);

    }
}
