using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IomarInn.Domain.Validation;

public class Util
{
    public void IsNullOrBlank(string value, string namesField)
    {
        DomainExceptionValidation.When
            (
                string.IsNullOrEmpty(value),
                $"{namesField}, cannot be blank."
            );
    }

    public void LengthSizeValidation(string value, int min, int max, string namesField)
    {
        DomainExceptionValidation.When
            (
                value.Length < min,
                $"{namesField}, must have {min} characters at least."
            );

        DomainExceptionValidation.When
            (
                value.Length > max,
                $"{namesField}, must cannot have more than {max} characters."
            );
    }
}
