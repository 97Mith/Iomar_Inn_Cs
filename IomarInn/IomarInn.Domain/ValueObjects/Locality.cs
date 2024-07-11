using Correios.Net;
    
namespace IomarInn.Domain.ValueObjects;

public class Locality
{
    public Address Address { get; private set; }


    public Locality(string zip)
    {
        Address address = SearchZip.GetAddress(zip);
        Address = address;
    }

    public Locality(string city, string district, string state, string street, string zip)
    {
        Address address = new Address();

        address.City = city;
        address.District = district;
        address.State = state;
        address.Street = street;
        address.Zip = zip;
        Address = address;

    }

}
