using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Dto;
using ASP.NETCoreAPI.Repositories;

namespace ASP.NETCoreAPI.Services.Implementations
{
    public class PersonServicesImpl : IPersonServices
    {
       
        //injeção de dependência
        private readonly IRepository<Person> _repository;
        private readonly AutoMapper.IMapper _mapper;

        //inicializando a injeção...
        public PersonServicesImpl(IRepository<Person> repository, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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

        public Person Update(UpdatePersonDto person)
        {
            var existingPerson = _repository.FindById(person.Id);
            if ( existingPerson == null ) return null;
            _mapper.Map(person, existingPerson);
            return _repository.Update(existingPerson);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
