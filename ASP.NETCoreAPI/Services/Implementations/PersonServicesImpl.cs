using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Context;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ASP.NETCoreAPI.Services.Implementations
{
    public class PersonServicesImpl : IPersonServices
    {
        //injeção de dependência
        private readonly PostgreSQLContext _context;

        //inicializando a injeção...
        public PersonServicesImpl(PostgreSQLContext context)
        {
            _context = context;
        }


        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            //var person = MockPerson(( int ) id);
            //return person;
            var data = _context.Persons.Find(id);
            if ( data != null )
            {
                return data;
            }
            return null;

        }

        public Person Create(Person person)
        {
            if ( person == null ) throw new ArgumentNullException(nameof(person));
            _context.Persons.Add(person);
            _context.SaveChanges();
            return person;
        }

        public Person Update(Person person)
        {
            //if ( person == null ) throw new ArgumentNullException(nameof(person));
            if ( person == null ) throw new NullReferenceException(nameof(person));
            var existingPerson = _context.Persons.Find(person.Id);
            if ( existingPerson == null ) throw new ArgumentNullException(nameof(existingPerson));
            _context.Entry(existingPerson).CurrentValues.SetValues(person);
            _context.SaveChanges();
            return person;
        }

        public bool Delete(long id)
        {   
            var existingPerson = _context.Persons.Find(id);
            if ( existingPerson == null ) return false;

            _context.Persons.Remove(existingPerson);
            _context.SaveChanges(); 

            return true;
        }




        // usar apenas para testes
        private Person MockPerson(int i)
        {
            string gender = i % 2 == 0 ? "Male" : "Female";
            var person = new Person
            {
                Id = new Random().Next(1, 1000),
                FirstName = "FirstName " + i,
                LastName = "LastName " + i,
                Address = "Rua tal 123",
                Gender = gender
            };
            return person;
        }
    }
}
