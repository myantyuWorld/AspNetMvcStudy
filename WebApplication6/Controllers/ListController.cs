using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class ListController : Controller
    {
        private RentalModel db = new RentalModel();

        // GET: List
        public ActionResult Index()
        {
            // 選択ボックスのオプションを準備
            Film film = new Film();
            film.title = "hoghoge";
            var films = db.Films.Take(10).ToList();

            var filmLanguage = new FilmLanguage();
            filmLanguage.films = films;

            return View(filmLanguage);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = db.Films.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        public ActionResult Complete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = db.Films.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult AsyncExistsLanguage(int? id)
        {
            if (id == null)
            {
                throw new Exception();
            }

            var _language = db.Languages.Find(id);
            if (_language == null)
            {
                return Json(new { returnText = "" }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { returnText = _language.name }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PartialProcessList(int? id)
        {
            var films = id == null ? null : db.Films.Where(x => x.language_id == id).ToList();

            return PartialView("PartialProcessList", films);
        }
    }
}