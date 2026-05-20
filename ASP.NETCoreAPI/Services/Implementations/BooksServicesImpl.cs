using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Context;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoMapper;


namespace ASP.NETCoreAPI.Services.Implementations
{
    public class BooksServicesImpl : IBookServices
    {

        //injeção de dependência
        private readonly PostgreSQLContext _context;
        private readonly AutoMapper.IMapper _mapper;


        //inicializando a injeção...
        public BooksServicesImpl(PostgreSQLContext context, AutoMapper.IMapper mapper)
        {
            _context = context;
            _mapper = mapper;        
        }

        public Books FindById(long id)
        {
           var data = _context.Books.Find(id);
            if ( data != null )
            {
                return data;
            }
            return data;
        }

        public List<Books> FindAll(int page, int pageSize)
        {
            return _context.Books.Skip(( page - 1 ) * pageSize).Take(pageSize).ToList();
        }
        

        public Books Create(Books book)
        {
            if ( book == null ) return null;         
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;            
        }
        
        public Books Update(UpdateBooksDto book)
        {
            if ( book == null ) throw new NullReferenceException(nameof(book));

            var existingBook = _context.Books.Find(book.Id);
            if ( existingBook == null ) return null;

            // usando AutoMapper, substituindo todos os 50 ifs possíveis por 1 linha:
            _mapper.Map(book, existingBook);
            //_context.Entry(existingBook).CurrentValues.SetValues(book);

            _context.SaveChanges();

            return existingBook;           
        }

        public bool Delete(long id)
        {
            var existingBook = _context.Books.Find(id);
            if ( existingBook == null ) return false;
            _context.Books.Remove(existingBook);
            _context.SaveChanges();
            return true;
        }          
    }
}
