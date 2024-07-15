using IomarInn.Domain.Entities;
using IomarInn.Domain.Interfaces;
using IomarInn.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace IomarInn.Infra.Data.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        ApplicationDbContext _companyContext;
        public CompanyRepository(ApplicationDbContext context)
        {
            _companyContext = context;
        }

        public async Task<Company> CreateAsync(Company company)
        {
            _companyContext.Add(company);
            await _companyContext.SaveChangesAsync();
            return company;
        }

        public async Task<Company> GetByIdAsync(int? id)
        {
            return await _companyContext.Companies.FindAsync(id);
        }

        public async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            return await _companyContext.Companies.ToListAsync();
        }

        public async Task<Company> RemoveAsync(Company company)
        {
            _companyContext.Remove(company);
            await _companyContext.SaveChangesAsync();
            return company;
        }

        public async Task<Company> UpdateAsync(Company company)
        {
            _companyContext.Update(company);
            await _companyContext.SaveChangesAsync();
            return company;
        }
    }
}
