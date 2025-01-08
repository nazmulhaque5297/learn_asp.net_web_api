using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CrudWithAsp.Validator;

namespace CrudWithAsp.Models.DTO
{
    public class StudentDto
    {
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]

        public int Class { get; set; }
        [StudentRollNumberValidator]
        public int RollNumber { get; set; }
        public int ClassTeacherId { get; set; }
    }
}
