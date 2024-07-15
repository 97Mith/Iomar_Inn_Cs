using IomarInn.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IomarInn.Infra.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) 
    { }

    //define a entidade que será mapeada e o nome da tabela
    public DbSet<Company> Companies { get; set; }
    public DbSet<Person> People { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
