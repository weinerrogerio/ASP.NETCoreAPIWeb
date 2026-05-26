using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Dto;

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
