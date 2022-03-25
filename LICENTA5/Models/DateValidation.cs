using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models
{
    public class DateValidation : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date;
            bool parsed = DateTime.TryParse(value.ToString(), out date);
            if (!parsed)
                return new ValidationResult("Invalid Date");
            else
            {
                //change below as per requirement
                var min = DateTime.Now.AddDays(-1);
                var max = DateTime.Now.AddYears(+1); 
                var msg = string.Format("Please enter a value between today and {1:MM/dd/yyyy}", min, max);
                try
                {
                    if (date < min || date > max)
                        return new ValidationResult(msg);
                    else
                        return ValidationResult.Success;
                }
                catch (Exception e)
                {
                    return new ValidationResult(e.Message);
                }
            }
        }
    }
}
