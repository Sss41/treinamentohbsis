using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class CustomNameValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (value.ToString().Contains("Carol"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Não existe!");
                }
            }
            return new ValidationResult("O campo "+validationContext.DisplayName + " é obrigatório.");
        }
    }
}