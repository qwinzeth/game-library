using GamesLegacySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamesLegacyMVC.Controllers
{
    public class HomeController : Controller
    {
        private SQLGames _sqlGames;

        // TODO: Dependency Injection
        public HomeController()
        {
            _sqlGames = new SQLGames();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetGames()
        {
            return Json(new { games = _sqlGames.GetGames() }, JsonRequestBehavior.AllowGet);
        }
    }
}