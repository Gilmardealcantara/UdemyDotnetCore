using System.Linq;
using System.Threading.Tasks;
using ITDeveloper.Data.ORM;
using Microsoft.EntityFrameworkCore;

namespace ITDeveloper.Mvc.Extensions.ViewComponents.Helpers {
    public static class Util {
        public static async Task<int> ToReg(ITDeveloperDbContext cxt) {
            return await cxt.Patients.AsNoTracking().CountAsync();
        }
        public static async Task<decimal> GetRegByState(ITDeveloperDbContext cxt, string stateDesc) {
            return await cxt.Patients
                .Include(p => p.State)
                .AsNoTracking()
                .Where(p => p.State.Description.Contains(stateDesc))
                .CountAsync();
        }
    }
}