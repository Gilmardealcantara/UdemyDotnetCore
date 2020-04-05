using System;
using Microsoft.EntityFrameworkCore;

namespace ITDeveloper.Data.ORM
{
    public class ITDeveloperDbContext: DbContext
    {
        public ITDeveloperDbContext(DbContextOptions<ITDeveloperDbContext> options)
            :base(options)
        {
        }
    }
}
