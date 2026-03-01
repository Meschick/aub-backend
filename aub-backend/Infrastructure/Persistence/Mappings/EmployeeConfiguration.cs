using aub_backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aub_backend.Infrastructure.Persistence.Mappings
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(x => x.Salary)
                .HasPrecision(18, 2);

            builder.Property(x => x.Commission)
                .HasPrecision(18, 2);
        }
    }
}
