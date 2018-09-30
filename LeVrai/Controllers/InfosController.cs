using LeVrai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeVrai.Controllers
{// 2 : creation du controlleur
    public class InfosController : Controller
    {
        public ActionResult About()
        {// creation de l'objet Info
            ViewData["InfoPax"] = "Information culinaire du developpeur";
            var about = new Info();

            // assignation de valeur
            about.Name = "Framboise";
            about.LastName = "Croustille";
            about.Level = Levels.;
            about.Function = "Developpeur junior"

            // retourne la Vue Info
            return View(about);
        }

    }
}