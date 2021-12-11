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
            ViewBag.SelectOptions = new SelectListItem[] {
                new SelectListItem() { Value="jQuery Tips", Text="jQuery Tips" },
                new SelectListItem() { Value="jQuery リファレンス ", Text="jQuery リファレンス " },
                new SelectListItem() { Value="jQuery サンプル集 ", Text="jQuery サンプル集 " },
                new SelectListItem() { Value="その他 ", Text="その他 " }
            };

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
            throw new Exception();

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
    }
}