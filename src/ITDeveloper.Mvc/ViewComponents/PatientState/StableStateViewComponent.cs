using System.Threading.Tasks;
using ITDeveloper.Mvc.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ITDeveloper.Mvc.ViewComponents.PatitentState {
    [ViewComponent(Name = "StableState")]
    public class StableStateViewComponent : ViewComponent {
        public StableStateViewComponent() {

        }
        public async Task<IViewComponentResult> InvokeAsync() {
            var total = Util.ToReg();
            var totalState = Util.GetRegByState();
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