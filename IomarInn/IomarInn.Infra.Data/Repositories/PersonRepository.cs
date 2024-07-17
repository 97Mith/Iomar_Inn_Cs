
using IomarInn.Domain.Entities;
using IomarInn.Domain.Interfaces;
using IomarInn.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace IomarInn.Infra.Data.Repositories;

public class PersonRepository : IPersonRepository
{
    ApplicationDbContext _context;
    public PersonRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Person> CreateAsync(Person person)
    {
        _context.Add<Person>(person);
        await _context.SaveChangesAsync();
        return person;
    }
    //TODO criar um eager loading
    public async Task<Person> GetByIdAsync(int? id)
    {
        return await _context.People.FindAsync(id);
    }

    public async Task<IEnumerable<Person>> GetEmployeesAsync(int companyId)
    {
        return await _context.People
                             .Where(p => p.CompanyId == companyId)
                             .ToListAsync();
    }

    public async Task<IEnumerable<Person>> GetPeopleAsync()
    {
        return await _context.People.ToListAsync();
    }

    public async Task<Person> RemoveAsync(Person person)
    {
        _context.Remove<Person>(person);
        await _context.SaveChangesAsync();
        return person;
    }

    public async Task<Person> UpdateAsync(Person person)
    {
        _context.Update<Person>(person);
        await _context.SaveChangesAsync();
        return person;
    }
}
