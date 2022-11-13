using Microsoft.AspNetCore.Mvc;

namespace admin_panel_metrica.Authentication
{
    public class Error404AltController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
