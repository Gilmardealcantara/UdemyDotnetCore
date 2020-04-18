using System.Threading.Tasks;
using ITDeveloper.Data.ORM;
using ITDeveloper.Mvc.Extencions.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ITDeveloper.Mvc.Extencions.ViewComponents.PatitentState {
    [ViewComponent(Name = "HeaderModule")]
    public class HeaderModuleViewComponent : ViewComponent {
        public HeaderModuleViewComponent() {}

        public async Task<IViewComponentResult> InvokeAsync(string title, string subtitle) {
            var model = new Modulo {
                Title = title,
                    SubTitle = subtitle
            };
            return View(model);
        }
    }
}