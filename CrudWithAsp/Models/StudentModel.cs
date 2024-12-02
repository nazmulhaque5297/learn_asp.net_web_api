using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithAsp.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string StudentName{get;set;}

        public int Class { get; set; }
        public int RollNumber { get; set; }

        public int ClassTeacherId { get; set; }
    }
}
