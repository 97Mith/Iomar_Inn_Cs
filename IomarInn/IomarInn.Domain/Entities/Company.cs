using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Entities;

public sealed class Company
{
    int Id { get; set; }
    public Name Name { get; private set; }
    public Name CoReason { get; private set; }
    public Cnpj Cnpj {  get; private set; }
    public Locality Address {  get; private set; }
    public StateInscription StateInsc {  get; private set; }
    public string PhoneNumber1 {  get; private set; } // tipo PhoneNumber
    public string PhoneNumber2 {  get; private set; }
    public string PhoneNumber3 {  get; private set; }
    public Email Email {  get; private set; }

    public Company(int id, Name name, Name coReason, Cnpj cnpj, Locality address, StateInscription si  /*outros atributos*/)
    {
        
    }
    public Company(Name name, Name coReason, Cnpj cnpj, Locality address /*atributos sem id*/)
    {
        
    }
    public ICollection<Person> Employees { get; private set; }
}

