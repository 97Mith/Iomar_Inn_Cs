using IomarInn.Domain.Entities;
using IomarInn.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IomarInn.Infra.Data.Context
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.ToLong(),
                    v => Id.Parse(v));

            builder.Property(n => n.Name)
                .HasMaxLength(50)
                .IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => new Name(v));

            builder.Property(n => n.LastName)
                .HasMaxLength(50)
                .IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => new Name(v));

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => new Cpf(v));

            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.Photo)
                .HasMaxLength(200);

            builder.Property(p => p.CompanyId)
                .HasConversion(
                    v => v.ToLong(),
                    v => Id.Parse(v));

            builder.HasOne(p => p.Company)
                .WithMany(c => c.Employees)
                .HasForeignKey(p => p.CompanyId);

            builder.ToTable("Persons");
        }
    }
}
