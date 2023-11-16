using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Components;

public class MainCarouselViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(string priotity)
    {
        //logika komponentu
        //z możliwym pobieraniem danych z bazy

        return View();
    }
}
