using aub_backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace aub_backend.Infrastructure.Persistence.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Vehicle> Vehicles => Set<Vehicle>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Usando o ApplyConfigurationsFromAssembly o mapeamento fica automatico.
            // Encontra classes que implementam: IEntityTypeConfiguration<T>. Se implementa o mapeamento e automatico

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }


    }
}
