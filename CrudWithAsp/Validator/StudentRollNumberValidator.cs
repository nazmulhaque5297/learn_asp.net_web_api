using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudWithAsp.Validator
{
    public class StudentRollNumberValidator: ValidationAttribute
    {
        protected override ValidationResult ? IsValid(object? value, ValidationContext validationContext)
        {
            var StudentRollNumber = value;
            Console.WriteLine(value);
            return ValidationResult.Success;
        }
    }
}
