using Microsoft.AspNetCore.Mvc;

namespace admin_panel_metrica.Authentication
{
    public class Error500Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
