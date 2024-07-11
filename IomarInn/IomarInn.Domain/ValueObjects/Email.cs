using IomarInn.Domain.Validation;

namespace IomarInn.Domain.ValueObjects;

public class Email
{
    public readonly string Value;

    public Email(string email)
    {
        Util.LengthSizeValidation(email, 3, 50, "Email");
        Value = email;
            
    }
}
