using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Entities;

public sealed class Company
{
    int Id { get; set; }
    public Name Name { get; private set; }
    public Name CoReason { get; private set; }
    public string Cnpj {  get; private set; } // tipo cnpj
    public string StateInsc {  get; private set; } // tipo SI
    public string PhoneNumber1 {  get; private set; } // tipo PhoneNumber
    public string PhoneNumber2 {  get; private set; }
    public string PhoneNumber3 {  get; private set; }
    public string Email {  get; private set; } // tipo Email

    public Company(int id, Name name, Name coReason /*outros atributos*/)
    {
        
    }
    public Company(Name name, Name coReason /*atributos sem id*/)
    {
        
    }
    public ICollection<Person> Employees { get; private set; }
}

