using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudWithAsp.Models;
using CrudWithAsp.Models.Repository;
using CrudWithAsp.Models.DTO;

namespace CrudWithAsp
{
    [Route("api/CrudWithAsp")]
    [ApiController]

    public class CrudController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<StudentDto> GetStudentInformation()
        {
            return SchoolRepository.Students;
        }

        [HttpGet("{id}")]
        public ActionResult< StudentModel>  GetStudentById(int id )
        {
            var student = SchoolRepository.Students.Where(x => x.Id == id).FirstOrDefault();
            if (student == null)
            {
                return NotFound($"The Student with id {id} is not found");
            }
            return Ok (student);
        }

        [HttpPost("create")]
        public ActionResult<StudentModel> CreateStudent([FromBody] StudentModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }
        }
    }
}
