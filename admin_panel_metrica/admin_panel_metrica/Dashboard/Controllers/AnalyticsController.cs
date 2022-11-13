using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace admin_panel_metrica.Dashboard.Controllers
{
    public class AnalyticsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
