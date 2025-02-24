using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using TestMyApp.Business.Interface;

namespace TestMyApp.Controllers
{
    [RoutePrefix("api/v1/message")]
    public class MessageController : ApiController
    {
        public readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        [Route("messagedetails")]
        public IHttpActionResult GetMessage()
        {            
            return Ok(_messageService.GetMessage());
        }
    }

    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}