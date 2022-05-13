using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models
{
    public class PremiumOffersValidation : ValidationAttribute
    {

        IStoreRepository repository;
        public PremiumOffersValidation()
        {
            
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var offersList = repository.GetOffers().ToList();
            List<string> codes = new List<string>();
            foreach(var o in offersList)
            {
                codes.Add(o.Code);
            }
          
            bool isFound = false;
            
                var msg = string.Format("Please enter valid code");
            try
            {
                foreach (var code in codes)
                {
                    if (code.Equals(value))
                    {
                        isFound = true;
                    }
                    else
                    {
                        isFound = false;

                    }
                }

                if (isFound != true)
                {
                    return new ValidationResult(msg);
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            catch (Exception e)
            {
                return new ValidationResult(e.Message);
            }
            
        }
    }
}
