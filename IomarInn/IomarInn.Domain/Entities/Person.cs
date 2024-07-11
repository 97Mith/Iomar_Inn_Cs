using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Entities;

public sealed class Person
{
    public int Id { get; private set; }
    public Name FirstName { get; private set; }
    public Name LastName { get; private set; }
    public string Cpf {  get; private set; }
    public string PhoneNumber {  get; private set; }
    public string Photo { get; private set; }

    public Person(int id, Name fistName, Name lastName)
    {
        
    }
    public Person(Name fistName, Name lastName)
    {
        
    }

    public int CompanyId { get; private set; }
    public Company Company { get; private set; }

}
