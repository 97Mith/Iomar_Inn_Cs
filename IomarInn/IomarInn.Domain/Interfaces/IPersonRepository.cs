using IomarInn.Domain.Entities;
using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Interfaces;

public interface IPersonRepository
{
    Task<IEnumerable<Person>> GetPeopleAsync();
    Task<Person> GetByIdAsync(Id? id);
    Task<Person> CreateAsync(Person person);
    Task<Person> UpdateAsync(Person person);
    Task<Person> RemoveAsync(Person person);
}
