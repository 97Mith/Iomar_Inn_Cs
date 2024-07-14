using FluentAssertions;
using IomarInn.Domain.ValueObjects;
using IomarInn.Domain.Entities;

namespace IomarInn.Domain.Tests;

public class CompanyUnitTest1
{
    [Fact(DisplayName = "Create Company With Valid State")]
    public void CreateCompany_WithValidParameters_ResultObjectValidState()
    {
        Id id = new Id(1);
        Name name = new Name("Company");
        Name coReason = new Name("Company LTDA");
        Cnpj cnpj = new Cnpj("00.600.903/0001-03");
        Address address = new Address("123 Main St", "Downtown", "Metropolis", "NY", "1234567");
        string phoneNumber = "41 36434002";
        Email email = new Email("example@gmail.com");

        Action action = () => new Company(id, name, coReason, cnpj, address, phoneNumber, null, null, email);
        action.Should()
            .NotThrow<IomarInn.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Company With Invalid CNPJ")]
    public void CreateCompany_WithInvalidCNPJ_ThrowException()
    {
        Id id = new Id(1);
        Name name = new Name("Company");
        Name coReason = new Name("Company LTDA");
        Action cnpj = () => new Cnpj("00.200.903/0001-03");
        Address address = new Address("123 Main St", "Downtown", "Metropolis", "NY", "1234567");
        string phoneNumber = "41 36434002";
        Email email = new Email("example@gmail.com");

        cnpj.Should()
            .Throw<IomarInn.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("CNPJ is invalid.");
    }

    [Fact(DisplayName = "Create Company With Null Address")]
    public void CreateCompany_WithNullAddress_ResultObjectValidState()
    {
        Id id = new Id(1);
        Name name = new Name("Company");
        Name coReason = new Name("Company LTDA");
        Cnpj cnpj = new Cnpj("00.600.903/0001-03");
        string phoneNumber = "41 36434002";
        Email email = new Email("example@gmail.com");

        Action action = () => new Company(id, name, coReason, cnpj, null, phoneNumber, null, null, email);
        action.Should()
            .NotThrow<IomarInn.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Company With Invalid Name")]
    public void CreateCompany_WithInvalidName_ThrowException()
    {
        Id id = new Id(1);
        Name name = new Name("Company");
        Action actionCoReason = () => new Name("Co");
        Cnpj cnpj = new Cnpj("00.600.903/0001-03");
        Address address = new Address("123 Main St", "Downtown", "Metropolis", "NY", "1234567");
        string phoneNumber = "41 36434002";
        Email email = new Email("example@gmail.com");

        actionCoReason.Should()
            .Throw<IomarInn.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Name length must be between 3 and 25 characters.");
    }

    [Fact(DisplayName = "Create Company With Null Email")]
    public void CreateCompany_WithNullEmail_ResultObjectValidState()
    {
        Id id = new Id(1);
        Name name = new Name("Company");
        Name coReason = new Name("Company LTDA");
        Cnpj cnpj = new Cnpj("00.600.903/0001-03");
        Address address = new Address("123 Main St", "Downtown", "Metropolis", "NY", "1234567");
        string phoneNumber = "41 36434002";

        Action action = () => new Company(id, name, coReason, cnpj, address, phoneNumber, null, null, null);
        action.Should()
            .NotThrow<IomarInn.Domain.Validation.DomainExceptionValidation>();
    }
}
