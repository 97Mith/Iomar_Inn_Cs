using IomarInn.Domain.Entities;
using IomarInn.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IomarInn.Infra.Data.Context
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
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

            builder.Property(c => c.CoReason)
                .HasMaxLength(100)
                .IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => new Name(v));

            builder.Property(c => c.Cnpj)
                .IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => new Cnpj(v));

            builder.OwnsOne(a => a.Address, a =>
            {
                a.Property(p => p.Street)
                    .HasMaxLength(50)
                    .HasColumnName("Street");

                a.Property(p => p.District)
                    .HasMaxLength(35)
                    .HasColumnName("District");

                a.Property(p => p.City)
                    .HasMaxLength(25)
                    .HasColumnName("City");

                a.Property(p => p.State)
                    .HasMaxLength(20)
                    .HasColumnName("State");

                a.Property(p => p.Zip)
                    .HasMaxLength(8)
                    .HasColumnName("Zip");
            });

            builder.Property(p => p.PhoneNumber1)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.PhoneNumber2)
                .HasMaxLength(20);

            builder.Property(p => p.PhoneNumber3)
                .HasMaxLength(20);

            builder.Property(e => e.Email)
                .HasConversion(
                    v => v.ToString(),
                    v => new Email(v))
                .HasMaxLength(100);

            // Relationship
            builder.HasMany(e => e.Employees)
                .WithOne()
                .HasForeignKey("CompanyId");

            builder.ToTable("Companies");
        }
    }
}
