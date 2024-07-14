namespace IomarInn.Domain.Tests;

using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using IomarInn.Domain.ValueObjects;
using IomarInn.Domain.Validation;

public class AddressVOTests
{
    [Fact(DisplayName = "Create Address Valid State")]
    public void CreateAddress_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Address("123 Main St", "Downtown", "Metropolis", "NY", "1234567");
        action.Should()
            .NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Address Invalid Street")]
    public void CreateAddress_WithInvalidStreet_ThrowException()
    {
        Action action = () => new Address("St", "Downtown", "Metropolis", "NY", "1234567");
        action.Should()
            .Throw<DomainExceptionValidation>()
            .WithMessage("Street length must be between 3 and 50 characters.");
    }

    [Fact(DisplayName = "Create Address Invalid District")]
    public void CreateAddress_WithInvalidDistrict_ThrowException()
    {
        Action action = () => new Address("123 Main St", "Do", "Metropolis", "NY", "1234567");
        action.Should()
            .Throw<DomainExceptionValidation>()
            .WithMessage("District length must be between 3 and 35 characters.");
    }

    [Fact(DisplayName = "Create Address Null or Blank City")]
    public void CreateAddress_WithNullOrBlankCity_ThrowException()
    {
        Action action = () => new Address("123 Main St", "Downtown", "", "NY", "1234567");
        action.Should()
            .Throw<DomainExceptionValidation>()
            .WithMessage("City cannot be null or blank.");
    }

    [Fact(DisplayName = "Create Address Invalid City Length")]
    public void CreateAddress_WithInvalidCityLength_ThrowException()
    {
        Action action = () => new Address("123 Main St", "Downtown", "Me", "NY", "1234567");
        action.Should()
            .Throw<DomainExceptionValidation>()
            .WithMessage("City length must be between 3 and 25 characters.");
    }

    [Fact(DisplayName = "Create Address Null or Blank State")]
    public void CreateAddress_WithNullOrBlankState_ThrowException()
    {
        Action action = () => new Address("123 Main St", "Downtown", "Metropolis", "", "1234567");
        action.Should()
            .Throw<DomainExceptionValidation>()
            .WithMessage("State cannot be null or blank.");
    }

    [Fact(DisplayName = "Create Address Invalid State Length")]
    public void CreateAddress_WithInvalidStateLength_ThrowException()
    {
        Action action = () => new Address("123 Main St", "Downtown", "Metropolis", "N", "1234567");
        action.Should()
            .Throw<DomainExceptionValidation>()
            .WithMessage("State length must be between 2 and 20 characters.");
    }

    [Fact(DisplayName = "Create Address Invalid Zip Code")]
    public void CreateAddress_WithInvalidZipCode_ThrowException()
    {
        Action action = () => new Address("123 Main St", "Downtown", "Metropolis", "NY", "1234");
        action.Should()
            .Throw<DomainExceptionValidation>()
            .WithMessage("Zip Code length must be between 7 and 8 characters.");
    }
}
