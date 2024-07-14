using FluentAssertions;
using IomarInn.Domain.Entities;
using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Tests;

public class PersonUnitTest1
{
    [Fact(DisplayName = "Create Person With Valid State")]
    public void CreatePerson_WithValidParameters_ResultObjectValidState()
    {
        Id id = new Id(1);
        Name firstName = new Name("John");
        Name lastName = new Name("Doe");
        Cpf cpf = new Cpf("123.456.789-09");
        string phoneNumber = "41 36434002";
        string photo = "photo.jpg";

        Action action = () => new Person(id, firstName, lastName, cpf, phoneNumber, photo);
        action.Should()
            .NotThrow<IomarInn.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Person With Valid State Null Conditional")]
    public void CreatePerson_WithValidParametersAndNullables_ResultObjectValidState()
    {
        Name firstName = new Name("John");
        Name lastName = new Name("Doe");

        Action action = () => new Person(firstName, lastName, null, null, null);
        action.Should()
            .NotThrow<IomarInn.Domain.Validation.DomainExceptionValidation>();
    }
}
