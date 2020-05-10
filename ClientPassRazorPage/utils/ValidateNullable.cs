using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace ClientPassRazorPage.utils
{
    public class ValidateNullable : ValidationAttribute
    {
    
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Date of Birth is required.");
            }
            else
            {
                return new ValidationResult("Date1111 of Birth is required.");
            }
        }


    }
}
