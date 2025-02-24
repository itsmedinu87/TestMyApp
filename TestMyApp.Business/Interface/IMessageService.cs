using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMyApp.Data.Repositories;

namespace TestMyApp.Business.Interface
{
    public interface IMessageService
    {
        MessageModel GetMessage();
    }
}
