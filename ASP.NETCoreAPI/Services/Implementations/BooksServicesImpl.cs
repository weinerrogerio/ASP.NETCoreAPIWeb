using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Context;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoMapper;
using ASP.NETCoreAPI.Repositories;
using ASP.NETCoreAPI.Data.DTO;
using Mapster;


namespace ASP.NETCoreAPI.Services.Implementations
{
    public class BooksServicesImpl : IBookServices
    {

        //injeção de dependência        
        private readonly IRepository<Book> _repository;


        //inicializando a injeção...
        public BooksServicesImpl(IRepository<Book> bookRepository)
        {
            _repository = bookRepository;
        }

        public BookDTO FindById(long id)
        {
            return _repository.FindById(id).Adapt<BookDTO>();
        }

        public List<BookDTO> FindAll(int page, int pageSize)
        {
            return _repository.FindAll(page, pageSize).Adapt<List<BookDTO>>();
        }

        public BookDTO Create(BookDTO book)
        {
            var entity = book.Adapt<Book>();
            entity = _repository.Create(entity);
            return entity.Adapt<BookDTO>();
        }


        public BookDTO Update(UpdateBooksDto book)
        {
            var entity = book.Adapt<Book>();
            entity = _repository.Update(entity);
            return entity.Adapt<BookDTO>();
        }

        public void Delete(long id)
        {
            _repository.Delete(id);  
        }          
    }
}
