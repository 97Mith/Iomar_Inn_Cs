using IomarInn.Domain.Entities;
using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Interfaces;

public interface ICompanyRepository
{
    Task<IEnumerable<Company>> GetCompaniesAsync();
    Task<Company> GetByIdAsync(Id? id);
    Task<Company> CreateAsync(Person person);
    Task<Company> UpdateAsync(Person person);
    Task<Company> RemoveAsync(Person person);
}
