using IomarInn.Domain.Validation;

namespace IomarInn.Domain.ValueObjects;

public class Id
{
    private readonly long _id;

    public Id(long id)
    {
        DomainExceptionValidation.When
            (
                id < 0,
                "Invalid ID"
            );
    
        _id = id;
    }
}
