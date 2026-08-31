using ASP.NETCoreAPI.Data.DTO;
using ASP.NETCoreAPI.Models;

namespace ASP.NETCoreAPI.Services
{
    public interface ITodoItemServices
    {
        TodoItem Create(TodoItem todoItem);
        List<TodoItem> FindAll(string? title, bool? isDone, int page = 1, int size = 10);
        TodoItem FindById(long id);
        TodoItem Update(UpdateTodoItemDto todoItem);
        bool Delete(long id);
    }
}
