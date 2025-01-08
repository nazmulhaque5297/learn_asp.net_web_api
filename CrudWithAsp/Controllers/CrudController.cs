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
            var students = SchoolRepository.Students.Select(s => new StudentDto() {
                Id = s.Id,
                StudentName = s.StudentName,
                ClassTeacherId = s.ClassTeacherId,
                Class = s.Class,
                RollNumber = s.RollNumber
            });
       
            return students;
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

        [HttpPost]
        public ActionResult<StudentDto> CreateStudent([FromBody] StudentDto model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            // we can validate rollnumber this way using ModelState 
            // There Is Second Way too where we can use CustomValidation
           // if (model.RollNumber <= 0)
           // {
           //     ModelState.AddModelError("RollNumber", "RollNumber Can not be less or eqal to 0");
           //     return BadRequest(ModelState);
           // }
            var lastId = SchoolRepository.Students.LastOrDefault().Id + 1;
            var newStudent = new StudentModel { Id = lastId,
                StudentName = model.StudentName,
                ClassTeacherId = model.ClassTeacherId,
                Class = model.Class,
                RollNumber = model.RollNumber };


            SchoolRepository.Students.Add(newStudent);

            return Ok(newStudent);


        }
    }
}
