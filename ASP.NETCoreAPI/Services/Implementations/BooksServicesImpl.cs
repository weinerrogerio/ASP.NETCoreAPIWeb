using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Context;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoMapper;
using ASP.NETCoreAPI.Repositories;
using ASP.NETCoreAPI.Models.Dto;


namespace ASP.NETCoreAPI.Services.Implementations
{
    public class BooksServicesImpl : IBookServices
    {

        //injeção de dependência        
        private readonly IRepository<Book> _repository;
        private readonly AutoMapper.IMapper _mapper;



        //inicializando a injeção...
        public BooksServicesImpl(IRepository<Book> bookRepository, AutoMapper.IMapper mapper)
        {
            _repository = bookRepository;
            _mapper = mapper;
        }

        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Book> FindAll(int page, int pageSize)
        {
            return _repository.FindAll(page, pageSize);
        }

        public Book Create(Book book)
        {
            if ( book == null ) return null;         
            return _repository.Create(book);
        }
        
        public Book Update(UpdateBooksDto book)
        {
            var existingBook = _repository.FindById(book.Id);
            if ( existingBook == null ) return null;
            _mapper.Map(book, existingBook);
            return _repository.Update(existingBook);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);  
        }          
    }
}
