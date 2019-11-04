using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistraImoveis.Models
{
    public class CustomValidator: ValidationAttribute
    {
        MigrationContext db = new MigrationContext();
        //"object value" é toda a informação colocada em nossa propriedade
        //é o que vem do postman e salvamos no  banco
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            if (validationContext.DisplayName == "Natal")
            {
                var dataInformada = DateTime.Parse(value.ToString());
                var idade = DateTime.Now.Year - dataInformada.Year;
                if (idade<18)
                    return new ValidationResult("Idade Inaceitável");
                if(idade>150)
                    return new ValidationResult("Idade Inaceitável");
            }
            return ValidationResult.Success;  
        }
    }
}