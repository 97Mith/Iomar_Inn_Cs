using DocsBr;
using IomarInn.Domain.Validation;

namespace IomarInn.Domain.ValueObjects;

public class Cnpj
{
    public readonly string Value;

    public Cnpj(String value)
    {
        Util.IsNullOrBlank(value, "CNPJ");

        CNPJ cNPJ = new CNPJ(value);

        DomainExceptionValidation.When
            (
                cNPJ.IsValid(), 
                "CNPJ is invalid."
            );

        Value = cNPJ.ComMascara();
    }
}
