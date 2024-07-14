using FluentAssertions;
using IomarInn.Domain.Entities;
using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Tests;

public class CompanyUnitTest1
{
   /* [Fact(DisplayName = "Create Company With Valid State")]
    public void CreateCompany_WithValidParameters_ResultObjectValidState()
    {
        Name name = new Name("Company");
        Name coReason = new Name("Company LTDA");
        Cnpj cnpj = new Cnpj("");
        Locality locality = new Locality("83707072");
        string phoneNumber = "41 36434002";
        Email email = new Email("exemple@gmail.com");

        Action action = () => new Company(name, coReason, null, locality, null, phoneNumber, null, null, email);
        action.Should().
            NotThrow<IomarInn.Domain.Validation.DomainExceptionValidation>();
    }*/
}
