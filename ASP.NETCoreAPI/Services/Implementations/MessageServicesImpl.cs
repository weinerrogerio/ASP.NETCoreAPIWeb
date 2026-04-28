using ASP.NETCoreAPI.Models;

namespace ASP.NETCoreAPI.Services.Implementations
{
    public class MessageServicesImpl : IMessageServices
    {
        public List<Message> FindAll()
        {
            var messages = new List<Message>();
            for ( int i = 0; i < 10; i++ )
            {
                messages.Add(MockMessage(i));
            }
            return messages;
        }

        public Message FindById(long id)
        {
            return MockMessage((int)id);
        }



        public Message Create(Message msg)
        {
            if ( string.IsNullOrEmpty(msg.Text) || msg.Text.Length > 150 ) return null;
            if ( string.IsNullOrEmpty(msg.Author)) return null;
            msg.Id = new Random().Next(1, 1000);
            return msg;
        }

        public Message Update(Message msg)
        {
            if ( string.IsNullOrEmpty(msg.Text) || msg.Text.Length > 150 ) return null;            
            return msg;
        }


        public Message Delete(long id)
        {
            return MockMessage((int)id);
        }

        private Message MockMessage(int i)
        {
            
            var message = new Message
            {
                Id = new Random().Next(1, 1000),
                Author= "Author " + i,
                Text = "Mensagem " + i

                
            };
            return message;
        }
    }
}
