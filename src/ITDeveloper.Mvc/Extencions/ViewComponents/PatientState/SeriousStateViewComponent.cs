using System.Threading.Tasks;
using ITDeveloper.Data.ORM;
using ITDeveloper.Mvc.Extensions.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ITDeveloper.Mvc.Extensions.ViewComponents.PatitentState {
    [ViewComponent(Name = "SeriousState")]
    public class SeriousStateViewComponent : ViewComponent {
        private readonly ITDeveloperDbContext _context;
        public SeriousStateViewComponent(ITDeveloperDbContext context) {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            var total = await Util.ToReg(_context);
            var totalState = await Util.GetRegByState(_context, "Grave");

            var progress = (totalState * 100) / total;
            var percent = progress.ToString(format: "F1");
            var model = new PatientStateData {
                Title = "Paciente Grave",
                Partial = (int)totalState,
                Percent = percent,
                Progress = progress,
                ClassContainer = "panel panel-info tile panelClose panelRefresh",
                IconLg = "l-banknote",
                IconSm = "fa fa-arrow-circle-o-down s20 mr5 pull-left"
            };
            return View(model);
        }
    }
}