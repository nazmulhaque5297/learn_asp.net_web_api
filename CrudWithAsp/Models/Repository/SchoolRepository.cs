using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithAsp.Models.Repository
{
    public static class SchoolRepository
    {
        public static  List<StudentModel> Students = new List<StudentModel>() {
                new StudentModel { Id=1,StudentName="Nazmul Haque",ClassTeacherId=1,Class=9,RollNumber=1},
                new StudentModel { Id=2,StudentName="Fazlul Haque",ClassTeacherId=1,Class=9,RollNumber=5}
            };
    }
}
