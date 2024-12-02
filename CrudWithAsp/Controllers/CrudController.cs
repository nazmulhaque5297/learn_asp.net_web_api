using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithAsp
{
    [Route("api/CrudWithAsp")]
    [ApiController]
    
    public class CrudController : ControllerBase
    {
        [HttpGet]

        public string Get()
        {
            return "Hi this is Nazmul";
        }
    }
}
