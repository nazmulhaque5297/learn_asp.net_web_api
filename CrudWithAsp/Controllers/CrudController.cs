using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudWithAsp.Models;

namespace CrudWithAsp
{
    [Route("api/CrudWithAsp")]
    [ApiController]
    
    public class CrudController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<StudentModel> GetStudentInformation()
        {
            return new List<StudentModel>() {
                new StudentModel { Id=1,StudentName="Nazmul Haque",ClassTeacherId=1,Class=9,RollNumber=1}
            };
        }
    }
}
