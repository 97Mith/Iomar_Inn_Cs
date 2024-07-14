using IomarInn.Domain.Validation;

namespace IomarInn.Domain.ValueObjects;

public class Cnpj
{
    public readonly string Value;

    public Cnpj(String value)
    {
        DomainExceptionValidation.When
            (
                !CnpjValidation.IsCNPJValid(value), 
                "CNPJ is invalid."
            );

        Value = value;
    }
}
