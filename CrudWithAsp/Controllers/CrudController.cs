using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudWithAsp.Models;
using CrudWithAsp.Models.Repository;

namespace CrudWithAsp
{
    [Route("api/CrudWithAsp")]
    [ApiController]
    
    public class CrudController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<StudentModel> GetStudentInformation()
        {
            return SchoolRepository.Students;
        }
    }
}
