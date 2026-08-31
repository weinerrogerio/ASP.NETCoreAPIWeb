using ASP.NETCoreAPI.Data.Converter.Implementations;
using ASP.NETCoreAPI.Data.DTO;
using ASP.NETCoreAPI.Models;
using FluentAssertions;

namespace ASP.NETCoreAPI.Tests
{
    public class PersonConverterTests
    {
        private readonly PersonConverter _converter;
        public PersonConverterTests()
        {
            _converter = new PersonConverter();
        }


        // Test method to verify that the Parse method correctly converts a PersonDTO to a Person
        [Fact]
        public void Parse_ShouldConvertPersonDtoToPerson()
        {
            // dto de entrada
            var dto = new PersonDTO
            {
                //arrange ou input: define o que eu quero testar - dados de entrada
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St",
                Gender = "Male",
                Birthday = new DateTime(1994, 1, 1)
            };


            // expected ou output: define o que eu espero como resultado
            var expectedPerson = new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St",
                Gender = "Male",
                Birthday = new DateTime(1994, 1, 1)
            };

            // act: chama o método que eu quero testar 
            var person = _converter.Parse(dto);

            //assert: verifica se o resultado é o esperado
            person.Should().NotBeNull();

            person.Id.Should().Be(expectedPerson.Id);
            person.FirstName.Should().Be(expectedPerson.FirstName);
            person.LastName.Should().Be(expectedPerson.LastName);
            person.Address.Should().Be(expectedPerson.Address);
            person.Gender.Should().Be(expectedPerson.Gender);
            person.Birthday.Should().Be(expectedPerson.Birthday);

            person.Should().BeEquivalentTo(expectedPerson);

        }


        // Test method to verify that the Parse method returns null when a null PersonDTO is passed
        [Fact]
        public void Parse_NullPersonDtoShouldReturnNull()
        {
            PersonDTO dto = null;
            var person = _converter.Parse(dto);
            person.Should().BeNull();
        }

        // Test method to verify that the Parse method correctly converts a Person to a PersonDTO
        [Fact]
        public void Parse_ShouldConvertPersonToPersonDto()
        {
            var entity = new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St",
                Gender = "Male",
                Birthday = new DateTime(1994, 1, 1)
            };

            var expectedDto = new PersonDTO
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St",
                Gender = "Male",
                Birthday = new DateTime(1994, 1, 1)
            };


            var dto = _converter.Parse(entity);
            dto.Should().NotBeNull();
            dto.Id.Should().Be(expectedDto.Id);
            dto.FirstName.Should().Be(expectedDto.FirstName);
            dto.LastName.Should().Be(expectedDto.LastName);
            dto.Address.Should().Be(expectedDto.Address);


        }

        [Fact]
        public void Parse_NullPersonShouldReturnNullDto()
        {
            Person entity = null;
            var dto = _converter.Parse(entity);
            dto.Should().BeNull();
        }


        [Fact]
        public void ParseList_ShouldConvertListOfPersonDtoToLisToPerson()
        {
            //arrange
            var dtoList = new List<PersonDTO>
            {
                new PersonDTO { Id = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", Gender = "Male" },
                new PersonDTO { Id = 2, FirstName = "Jane", LastName = "Smith", Address = "456 Elm St", Gender = "Female" }

            };

            //act
            var personList = _converter.ParseList(dtoList);

            //assert
            personList.Should().NotBeNull();
            personList.Count.Should().Be(2);
            personList[0].Should().BeEquivalentTo(
                new Person { Id = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", Gender = "Male" }
                );
            personList[1].Should().BeEquivalentTo(
                new Person { Id = 2, FirstName = "Jane", LastName = "Smith", Address = "456 Elm St", Gender = "Female" }
                );
            
        }

        [Fact]
        public void Parse_NullListPersonDtoShouldReturnNull()
        {
           List<PersonDTO> dto = null;
            var listpPerson = _converter.ParseList(dto);
            listpPerson.Should().BeNull();
        }

        [Fact]
        public void ParseList_ShouldConvertPersonListToPersonDTOList()
        {
            // Arrange
            var dtoList = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "Mahatma",
                    LastName = "Gandhi",
                    Address = "Porbandar - India",
                    Gender = "Male",
                    //BirthDay = new DateTime(1869, 10, 2)
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Indira",
                    LastName = "Gandhi",
                    Address = "Allahabad - India",
                    Gender = "Female",
                    //BirthDay = new DateTime(1917, 11, 19)
                }
            };

            // Act
            var personList = _converter.ParseList(dtoList);

            // Assert
            personList.Should().NotBeNull();
            personList.Should().HaveCount(2);

            personList[0].Should().BeEquivalentTo(new PersonDTO
            {
                Id = 1,
                FirstName = "Mahatma",
                LastName = "Gandhi",
                Address = "Porbandar - India",
                Gender = "Male",
                Birthday = new DateTime(1869, 10, 2)
            }, options => options.Excluding(person => person.Birthday));

            personList[1].Should().BeEquivalentTo(new PersonDTO
            {
                Id = 2,
                FirstName = "Indira",
                LastName = "Gandhi",
                Address = "Allahabad - India",
                Gender = "Female",
                Birthday = new DateTime(1917, 11, 19)
            }, options => options.Excluding(person => person.Birthday));

            personList[0].FirstName.Should().Be("Mahatma");
            personList[1].FirstName.Should().Be("Indira");
            personList[1].LastName.Should().Be("Gandhi");
        }

        [Fact]
        public void Parse_NullListPersonShouldReturnNull()
        {
            List<Person> dto = null;
            var listPerson = _converter.ParseList(dto);
            listPerson.Should().BeNull();
        }

    }
}
