using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMyApp.Data.Interface;

namespace TestMyApp.Data.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        public MessageModel GetMessage()
        {
            var msg = new MessageModel
            {
                Id = 1,
                Title = "Test"
            };
            return msg;
        }
    }

    public class MessageModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
