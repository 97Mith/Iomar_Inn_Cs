using FluentAssertions;
using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Tests;

public class ValueObjectsTest1
{
    [Fact(DisplayName = "Create CNPJ Valid State")]
    public void CreateCnpj_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Cnpj("00.600.903/0001-03");
        action.Should()
            .NotThrow<IomarInn.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create CNPJ Invalid State")]
    public void CreateCnpj_WithInvalidParameters_ThrowException()
    {
        Action action = () => new Cnpj("44.414.123/0001-03");
        action.Should()
            .Throw<IomarInn.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("CNPJ is invalid.");
    }

    [Fact(DisplayName = "Create CNPJ Valid State (With Letters)")]
    public void CreateCnpj_WithLetters_NotThrowException()
    {
        Action action = () => new Cnpj("00.600.as903/0001-03");
        action.Should()
            .NotThrow<IomarInn.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create CNPJ Invalid State")]
    public void CreateCnpj_WithLettersParameters_ResultObjectValidState()
    {
        Action action = () => new Cnpj("asssaaaaaa");
        action.Should()
            .Throw<IomarInn.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("CNPJ is invalid.");
    }

    [Fact(DisplayName = "Create CNPJ Null")]
    public void CreateCnpj_Null_NotThrowException()
    {
        Action action = () => new Cnpj("");
        action.Should()
            .Throw<IomarInn.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("CNPJ is invalid.");
    }
}
