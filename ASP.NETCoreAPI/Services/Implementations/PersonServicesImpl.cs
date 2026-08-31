using ASP.NETCoreAPI.Data.Converter.Implementations;
using ASP.NETCoreAPI.Data.DTO;
using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Repositories;
using Mapster;
using Npgsql.Internal;

namespace ASP.NETCoreAPI.Services.Implementations
{
    public class PersonServicesImpl : IPersonServices
    {
       
        //injeção de dependência
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;
        private readonly AutoMapper.IMapper _mapper;

        //inicializando a injeção...
        public PersonServicesImpl(IRepository<Person> repository, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _converter = new PersonConverter();
            _mapper = mapper;
        }


        public List<PersonDTO> FindAll(int page, int pageSize)
        {
            return _converter.ParseList(_repository.FindAll(page, pageSize));
        }

        public PersonDTO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id)); 
        }


        public PersonDTO Create(PersonDTO person)
        {
            var entity = _converter.Parse(person);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public PersonDTO Update(UpdatePersonDto person)
        {            
            var existingPerson = _repository.FindById(person.Id);
            if ( existingPerson == null ) return null;

            // O AutoMapper atualiza as propriedades de existingPerson com base no DTO
            //_mapper.Map(person, existingPerson);

            //var updatedEntity = _repository.Update(existingPerson);

            //// Retorna convertendo a entidade atualizada para PersonDTO
            //return _converter.Parse(updatedEntity);

            //var entity = person.Adapt<Person>();
            //entity = _repository.Update(entity);
            //return entity.Adapt<PersonDTO>();

            // 1. Criamos uma configuração local do Mapster
            var config = new TypeAdapterConfig();
            // 2. Avisamos que, ao converter de UpdatePersonDto para Person, ele deve ignorar os nulos
            config.NewConfig<UpdatePersonDto, Person>()
                  .IgnoreNullValues(true);
            // 3. Passamos essa configuração junto com o Adapt
            var updatedEntity = person.Adapt(existingPerson, config);
            updatedEntity = _repository.Update(existingPerson);
            return updatedEntity.Adapt<PersonDTO>();
            //return _converter.Parse(updatedEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
