using ITDeveloper.Domain.Entitites;
using Microsoft.EntityFrameworkCore;

namespace ITDeveloper.Data.ORM
{
    public class ITDeveloperDbContext: DbContext
    {
        public ITDeveloperDbContext(DbContextOptions<ITDeveloperDbContext> options)
            :base(options)
        {}

        public DbSet<Mural> Murals { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
