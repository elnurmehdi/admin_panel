using Microsoft.AspNetCore.Mvc;

namespace admin_panel_metrica.Authentication
{
    public class Error500AltController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
