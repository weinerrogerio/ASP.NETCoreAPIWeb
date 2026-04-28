using ASP.NETCoreAPI.Models;

namespace ASP.NETCoreAPI.Services
{
    public interface IMessageServices
    {
        Message Create(Message Message);
        Message FindById(long id);
        List<Message> FindAll();
        Message Update(Message Message);
        Message Delete(long id);
    }
}
