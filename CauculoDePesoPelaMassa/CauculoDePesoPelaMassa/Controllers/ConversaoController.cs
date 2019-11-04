using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CauculoDePesoPelaMassa.Model;

namespace CauculoDePesoPelaMassa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversaoController : ControllerBase
    {
        [HttpPost]
        public ConversaoMassa Post(ConversaoMassa item) 
        {
            return item;
        }
    }
}