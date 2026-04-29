using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Repositories;

namespace ASP.NETCoreAPI.Services.Implementations
{
    public class PersonServicesImpl : IPersonServices
    {
       
        //injeção de dependência
        private readonly IPersonRepository _repository;

        //inicializando a injeção...
        public PersonServicesImpl(IPersonRepository repository)
        {
            _repository = repository;
        }


        public List<Person> FindAll(int page, int pageSize)
        {
            return _repository.FindAll(page, pageSize);
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {

            return _repository.Update(person);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }
    }
}
