using System.Threading.Tasks;
using ITDeveloper.Mvc.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ITDeveloper.Mvc.ViewComponents.PatitentState {
    [ViewComponent(Name = "ObservationStateViewComponent")]

    public class ObservationStateViewComponent : ViewComponent {
        public ObservationStateViewComponent() {

        }
        public async Task<IViewComponentResult> InvokeAsync() {
            var total = Util.ToReg();
            var totalState = Util.GetRegByState();
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