using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        public IEnumerable<Models.Message> Get()
        {
            return new Models.Message[]
            {
                new Models.Message
                {
                    Owner = "Jakkavat",
                    Text = "Heloo Bank!"
                },
                new Models.Message
                {
                    Owner = "John",
                    Text = "Heloo John!"
                }
            };

        }
    }
}