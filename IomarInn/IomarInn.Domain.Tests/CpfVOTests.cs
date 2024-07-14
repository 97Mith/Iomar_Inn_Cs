using FluentAssertions;
using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Tests;

public class CpfVOTests
{
    [Fact(DisplayName = "Create CPF Valid State")]
    public void CreateCpf_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Cpf("123.456.789-09");
        action.Should()
            .NotThrow<IomarInn.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create CPF Invalid State")]
    public void CreateCpf_WithInvalidParameters_ThrowException()
    {
        Action action = () => new Cpf("123.456.789-00");
        action.Should()
            .Throw<IomarInn.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("CPF is invalid.");
    }

    [Fact(DisplayName = "Create CPF Valid State (With Letters)")]
    public void CreateCpf_WithLetters_NotThrowException()
    {
        Action action = () => new Cpf("123.456.as789-09");
        action.Should()
            .NotThrow<IomarInn.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create CPF Invalid State")]
    public void CreateCpf_WithLettersParameters_ThrowException()
    {
        Action action = () => new Cpf("asssaaaaaaa");
        action.Should()
            .Throw<IomarInn.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("CPF is invalid.");
    }

    [Fact(DisplayName = "Create CPF Null")]
    public void CreateCpf_Null_NotThrowException()
    {
        Action action = () => new Cpf("");
        action.Should()
            .NotThrow<NullReferenceException>();
    }
}
