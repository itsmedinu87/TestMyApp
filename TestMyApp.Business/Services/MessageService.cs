using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMyApp.Business.Interface;
using TestMyApp.Data.Interface;
using TestMyApp.Data.Repositories;

namespace TestMyApp.Business.Services
{
    public class MessageService : IMessageService
    {
        public readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public MessageModel GetMessage()
        {
            return _messageRepository.GetMessage();
        }
    }
}
