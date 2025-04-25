using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.Controllers
{
    public class UserLayoutController : Controller
    {
        public IActionResult LayoutUI()
        {
            return View();
        }
    }
}
