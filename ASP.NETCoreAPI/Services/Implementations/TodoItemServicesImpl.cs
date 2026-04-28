using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Context;

namespace ASP.NETCoreAPI.Services.Implementations
{
    public class TodoItemServicesImpl : ITodoItemServices
    {

        //injeção de dependência
        private readonly PostgreSQLContext _context;


        //inicializando a injeção...
        public TodoItemServicesImpl(PostgreSQLContext context)
        {
            _context = context;
        }

        public List<TodoItem> FindAll(string? title, bool? isDone, int page, int size)
        {

            
            Console.WriteLine($"CHAMANDO FindAll................ title: {title}, isDone: {isDone}, page: {page}, size: {size}");
            var query = _context.TodoItems.AsQueryable();

            if ( !string.IsNullOrWhiteSpace(title) )
            {
                Console.WriteLine($"PROCURANDO POR title: {title}");
                query = query.Where(t => t.Title.Contains(title));
            }

            if ( isDone.HasValue )
            {
                Console.WriteLine($"PROCURANDO POR isDone: {isDone.Value}");
                query = query.Where(t => t.IsDone == isDone.Value);
            }

            return query.OrderBy(t => t.Id).Skip(( page - 1 ) * size).Take(size).ToList();
        }

        public TodoItem FindById(long id)
        {
            var item = _context.TodoItems.Find(id);
           return item;
        }

        public TodoItem Create(TodoItem todoItem)
        {
            if ( todoItem == null ) return null;
            todoItem.IsDone = false; // inicia sempre como pendente
            _context.TodoItems.Add(todoItem);
            _context.SaveChanges();
            return todoItem;
        }


        public TodoItem Update(UpdateTodoItemDto dto)
        {
            var existingItem = _context.TodoItems.Find(dto.Id);
            if ( existingItem == null ) return null;

            if ( dto.Title != null ) existingItem.Title = dto.Title;
            if ( dto.Description != null ) existingItem.Description = dto.Description;
          
            if ( dto.IsDone.HasValue )
            {
                var hasDescription = !string.IsNullOrWhiteSpace(existingItem.Description);
                if ( dto.IsDone.Value && !hasDescription ) return null;

                existingItem.IsDone = dto.IsDone.Value;
            }

            _context.SaveChanges();
            return existingItem;
        }

        public bool Delete(long id)
        {
            var existingTodoItem = _context.TodoItems.Find(id);
            if ( existingTodoItem == null ) return false;
            _context.TodoItems.Remove(existingTodoItem);
            _context.SaveChanges();
            return true;
        }

        
    }
}
