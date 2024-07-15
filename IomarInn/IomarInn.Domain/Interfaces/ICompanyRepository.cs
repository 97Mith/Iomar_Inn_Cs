using IomarInn.Domain.Entities;
using IomarInn.Domain.ValueObjects;

namespace IomarInn.Domain.Interfaces;

public interface ICompanyRepository
{
    Task<IEnumerable<Company>> GetCompaniesAsync();
    Task<Company> GetByIdAsync(int? id);
    Task<Company> CreateAsync(Company company);
    Task<Company> UpdateAsync(Company company);
    Task<Company> RemoveAsync(Company company);
}
