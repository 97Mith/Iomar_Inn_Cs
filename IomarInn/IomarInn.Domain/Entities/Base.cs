namespace IomarInn.Domain.Entities;
using IomarInn.Domain.ValueObjects;

public abstract class Base
{
    public int Id { get; protected set; }
    public Name Name { get; protected set; }
}
