using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudWithAsp.Models.DTO;
namespace CrudWithAsp.Models.Repository
{
    public static class SchoolRepository
    {
        public static  List<StudentDto> Students = new List<StudentDto>() {
                new StudentDto { Id=1,StudentName="Nazmul Haque",ClassTeacherId=1,Class=9,RollNumber=1},
                new StudentDto { Id=2,StudentName="Fazlul Haque",ClassTeacherId=1,Class=9,RollNumber=5}
            };
    }
}
