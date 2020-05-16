using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bookflix.Data;

namespace Bookflix.Models.Validacion
{
    public class ISBNRepetidoAttribute : ValidationAttribute
    {
        public string GetErrorMessage() => "ISBN ya existente";
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((value != null) && (ISBNDuplicado((int)value)))
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }

        private bool ISBNDuplicado(int ISBN)
        {
            using (var db = new BookflixContext())
            {
                return (db.Libros.Any(libro => libro.ISBN == ISBN));
            }
        }
    }
}
