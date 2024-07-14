using IomarInn.Domain.Validation;

namespace IomarInn.Domain.ValueObjects;

public class Cpf
{
    public readonly string Value;

    public Cpf(string value)
    {
        DomainExceptionValidation.When
            (
                !CpfValidation.IsCPFValid(value),
                "CPF is invalid."
            );

        Value = value;
    }
}
