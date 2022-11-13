using Microsoft.AspNetCore.Mvc;

namespace admin_panel_metrica.Dashboard.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
