using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ITDeveloper.Data.Mapings;
using ITDeveloper.Domain.Entitites;
using Microsoft.EntityFrameworkCore;

namespace ITDeveloper.Data.ORM {
    public class ITDeveloperDbContext : DbContext {
        public ITDeveloperDbContext(DbContextOptions<ITDeveloperDbContext> options) : base(options) {}

        public DbSet<Mural> Murals { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientState> PatientStates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            // Change string format convetion (nvarchar(max))
            var allStringDbProperies = builder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string)));

            foreach (var property in allStringDbProperies) {
                property.Relational().ColumnType = "varchar(100)";
            }

            builder.ApplyConfiguration(new PatientMap());
            builder.ApplyConfiguration(new PatientStateMap());

            // Get all maps
            // builder.ApplyConfigurationsFromAssembly(typeof(ITDeveloperDbContext).Assembly);

            // Set Security Delte Behavior
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken)) {

            var entries = ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity.GetType().GetProperty("CreateAt") != null ||
                    e.Entity.GetType().GetProperty("UpdateAt") != null
                );

            foreach (var entry in entries) {
                if (entry.State == EntityState.Added) {
                    entry.Property("CreateAt").CurrentValue = DateTime.Now;
                    entry.Property("UpdateAt").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified) {
                    entry.Property("CreateAt").IsModified = false;
                    entry.Property("UpdateAt").CurrentValue = DateTime.Now;
                    entry.Property("UpdateAt").IsModified = true;
                }
            }
            return base.SaveChangesAsync();
        }

    }
}