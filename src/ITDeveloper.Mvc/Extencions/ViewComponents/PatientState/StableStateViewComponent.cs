using System.Threading.Tasks;
using ITDeveloper.Data.ORM;
using ITDeveloper.Mvc.Extensions.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ITDeveloper.Mvc.Extensions.ViewComponents.PatitentState {
    [ViewComponent(Name = "StableState")]
    public class StableStateViewComponent : ViewComponent {
        private readonly ITDeveloperDbContext _context;
        public StableStateViewComponent(ITDeveloperDbContext context) {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            var total = Util.ToReg(_context);
            var totalState = Util.GetRegByState(_context, "Estável");

            var progress = (totalState * 100) / total;
            var percent = progress.ToString(format: "F1");
            var model = new PatientStateData {
                Title = "Paciente Estável",
                Partial = (int)totalState,
                Percent = percent,
                Progress = progress,
                ClassContainer = "panel panel-success tile panelClose panelRefresh",
                IconLg = "l-basic-geolocalize-05",
                IconSm = "fa fa-arrow-circle-o-up s20 mr5 pull-left"
            };
            return View(model);
        }
    }
}