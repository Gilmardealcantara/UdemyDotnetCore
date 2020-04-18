using System.Linq;
using ITDeveloper.Data.ORM;
using Microsoft.EntityFrameworkCore;

namespace ITDeveloper.Mvc.ViewComponents.Helpers {
    public static class Util {
        public static int ToReg(ITDeveloperDbContext cxt) {
            return cxt.Patients.AsNoTracking().Count();
        }
        public static decimal GetRegByState(ITDeveloperDbContext cxt, string stateDesc) {
            return cxt.Patients
                .Include(p => p.State)
                .AsNoTracking()
                .Where(p => p.State.Description.Contains(stateDesc))
                .Count();
        }
    }
}