using DocsBr;
using IomarInn.Domain.Validation;

namespace IomarInn.Domain.ValueObjects;

public class Cpf
{
    public readonly string Value;

    public Cpf(string value)
    {
        CPF cPF = new CPF(value);

        DomainExceptionValidation.When
            (
                cPF.IsValid(),
                "CPF is invalid."
            );

        Value = cPF.ComMascara();
    }
}
