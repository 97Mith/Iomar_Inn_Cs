using IomarInn.Domain.Validation;

namespace IomarInn.Domain.ValueObjects;
public class Name
{
    private string Value;

    public Name(string value)
    {
        Util.IsNullOrBlank(value, nameof(value));
        Util.LengthSizeValidation(value, 3, 25, nameof(value));

        Value = value;
    }
}
