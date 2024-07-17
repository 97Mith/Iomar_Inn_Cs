using IomarInn.Domain.Validation;
using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Entities;

public sealed class Company : Base
{
    public Name CoReason { get; private set; }
    public Cnpj Cnpj {  get; private set; }
    public Address Address {  get; private set; }
    public string PhoneNumber1 {  get; private set; } // tipo PhoneNumber
    public string PhoneNumber2 {  get; private set; }
    public string PhoneNumber3 {  get; private set; }
    public Email Email {  get; private set; }
    public ICollection<Person> Employees { get; set; }
    public Company()
    {
        
    }

    public Company(int id, Name name, Name coReason, Cnpj cnpj, Address? address,  string pn1, string? pn2, string? pn3, Email? email)
    {
        DomainExceptionValidation.When(id < 0, "Invalid ID");
        Id = id;
        Name = name;
        CoReason = coReason;
        Cnpj = cnpj;
        Address = address;
        PhoneNumber1 = pn1;
        PhoneNumber2 = pn2;
        PhoneNumber3 = pn3;
        Email = email;

    }
    public Company(Name name, Name coReason, Cnpj cnpj, Address? address, string pn1, string? pn2, string? pn3, Email? email)
    {
        Name = name;
        CoReason = coReason;
        Cnpj = cnpj;
        Address = address;
        PhoneNumber1 = pn1;
        PhoneNumber2 = pn2;
        PhoneNumber3 = pn3;
        Email = email;
    }
    
    public void UpdateName(Name name)
    {
        Name = name; 
    }
    public void UpdateCoReason(Name coReason)
    {
        CoReason = coReason;
    }

    public void UpdateCnpj(Cnpj cnpj)
    {
        Cnpj = cnpj;
    }

    public void UpdateAddress(Address address)
    {
        Address = address;
    }

    public void UpdatePhoneNumber1(string pn1)
    {
        PhoneNumber1 = pn1;
    }

    public void UpdatePhoneNumber2(string pn2)
    {
        PhoneNumber2 = pn2;
    }

    public void UpdatePhoneNumber3(string pn3)
    {
        PhoneNumber3 = pn3;
    }

    public void UpdateEmail(Email email)
    {
        Email = email;
    }

    public void AddEmployee(Person employee)
    {
        Employees.Add(employee);
    }

    public void RemoveEmployee(Person employee)
    {
        Employees.Remove(employee);
    }

}

