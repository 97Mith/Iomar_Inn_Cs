using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IomarInn.Domain.Validation;

public class Util
{
    public static void IsNullOrBlank(string value, string namesField)
    {
        DomainExceptionValidation.When
            (
                string.IsNullOrEmpty(value),
                $"{namesField} cannot be null or blank."
            );
    }

    public static void LengthSizeValidation(string value, int min, int max, string namesField)
    {
        DomainExceptionValidation.When
            (
                value.Length < min,
                $"{namesField} length must be between {min} and {max} characters."
            );
        DomainExceptionValidation.When
            (
                value.Length > max,
                $"{namesField} length must be between {min} and {max} characters."
            );
    }
}
