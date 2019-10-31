using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiimobiliaria.Models
{
    public class CustomValidator: ValidationAttribute
    {
        Model1 db = new Model1();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext.DisplayName == "Nome")
            {
                if (db.Proprietario.FirstOrDefault(x => x.Nome == value.ToString())
                != null)
                    return new ValidationResult("Usuario ja cadastrado");
            }


            if (validationContext.DisplayName == "DataNascimento")
            {
                var idade = DateTime.Now.Year - DateTime.Parse(value.ToString()).Year;
                if (idade <18)
                    return new ValidationResult("Usuario Sem idade permitida.");

                if (idade >=150)
                    return new ValidationResult("Vocejá morreu.");
            }
            return ValidationResult.Success;

        }
    }
}