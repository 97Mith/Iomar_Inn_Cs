using IomarInn.Domain.Validation;

namespace IomarInn.Domain.ValueObjects;

public class Address
{
    public string Street { get; }
    public string District { get; }
    public string City { get; }
    public string State { get; }
    public string Zip { get; }

    public Address(string? street, string? district, string city, string state, string? zip)
    {
        Util.LengthSizeValidation(street, 3, 50, "Street");

        Util.LengthSizeValidation(district, 3, 35, "District");
        
        Util.IsNullOrBlank(city, "City");
        
        Util.LengthSizeValidation(city, 3, 25, "City");
        
        Util.IsNullOrBlank(state, "State");

        Util.LengthSizeValidation(state, 2, 20, "State");

        Util.LengthSizeValidation(zip, 7, 8, "Zip Code");

        Street = street;
        District = district;
        City = city;
        State = state;
        Zip = zip;

    }
    public override string ToString()
    {
        return $"{Street};{District};{City};{State};{Zip}";
    }

    public static Address Parse(string addressString)
    {
        var parts = addressString.Split(';');
        return new Address(parts[0], parts[1], parts[2], parts[3], parts[4]);
    }
}
