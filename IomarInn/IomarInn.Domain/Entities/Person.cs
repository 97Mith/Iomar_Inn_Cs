using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Entities;

public sealed class Person : Base
{
    public Name LastName { get; private set; }
    public Cpf Cpf { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Photo { get; private set; }

    public Id CompanyId { get; set; }
    public Company Company { get; set; }

    public Person(Id id, Name firstName, Name lastName, Cpf cpf, string? phoneNumber, string? photo)
    {
        Id = id;
        Name = firstName;
        LastName = lastName;
        Cpf = cpf;
        PhoneNumber = phoneNumber;
        Photo = photo;
    }

    public Person(Name firstName, Name lastName, Cpf cpf, string? phoneNumber, string? photo)
    {
        Name = firstName;
        LastName = lastName;
        Cpf = cpf;
        PhoneNumber = phoneNumber;
        Photo = photo;
    }

    public void UpdateFirstName(Name firstName)
    {
        Name = firstName;
    }

    public void UpdateLastName(Name lastName)
    {
        LastName = lastName;
    }

    public void UpdateCpf(Cpf cpf)
    {
        Cpf = cpf;
    }

    public void UpdatePhoneNumber(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    public void UpdatePhoto(string photo)
    {
        Photo = photo;
    }

    public void UpdateCompany(Id companyId, Company company)
    {
        CompanyId = companyId;
        Company = company;
    }
    public void DeleteFirstName()
    {
        Name = null;
    }

    public void DeleteLastName()
    {
        LastName = null;
    }

    public void DeleteCpf()
    {
        Cpf = null;
    }

    public void DeletePhoneNumber()
    {
        PhoneNumber = null;
    }

    public void DeletePhoto()
    {
        Photo = null;
    }
}