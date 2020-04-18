using System.Threading.Tasks;
using ITDeveloper.Data.ORM;
using ITDeveloper.Mvc.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ITDeveloper.Mvc.ViewComponents.PatitentState {
    [ViewComponent(Name = "ObservationStateViewComponent")]

    public class ObservationStateViewComponent : ViewComponent {
        private readonly ITDeveloperDbContext _context;
        public ObservationStateViewComponent(ITDeveloperDbContext context) {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            var total = Util.ToReg(_context);
            var totalState = Util.GetRegByState(_context, "Observação");

            var progress = (totalState * 100) / total;
            var percent = progress.ToString(format: "F1");
            var model = new PatientStateData {
                Title = "Paciente em Observação",
                Partial = (int)totalState,
                Percent = percent,
                Progress = progress,
                ClassContainer = "panel panel-default tile panelClose panelRefresh",
                IconLg = "l-ecommerce-cart-content",
                IconSm = "fa fa-arrow-circle-o-up s20 mr5 pull-left"
            };
            return View(model);
        }
    }
}