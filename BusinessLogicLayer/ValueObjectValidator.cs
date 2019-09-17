using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ValueObjectValidator
    {
        public ValueObjectValidator() { }

        public bool TryValidate(object @object, out List<ValidationResult> results)
        {
            ValidationContext context = new ValidationContext(@object);
            results = new List<ValidationResult>();

            return Validator.TryValidateObject(
                @object, context, results,
                validateAllProperties: true
            );
        }
    }
}