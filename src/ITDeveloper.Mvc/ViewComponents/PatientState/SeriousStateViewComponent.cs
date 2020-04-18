using System.Threading.Tasks;
using ITDeveloper.Mvc.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ITDeveloper.Mvc.ViewComponents.PatitentState {
    [ViewComponent(Name = "SeriousState")]
    public class SeriousStateViewComponent : ViewComponent {
        public SeriousStateViewComponent() {

        }

        public async Task<IViewComponentResult> InvokeAsync() {
            var total = Util.ToReg();
            var totalState = Util.GetRegByState();
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