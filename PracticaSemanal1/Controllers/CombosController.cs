using PracticaSemanal1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaSemanal1.Controllers
{
    public class CombosController : Controller
    {

        readonly CineDbConnection db = new CineDbConnection();

       // GET: Combos
        public ActionResult Index()
        {
            //metodo lamtamp
            var combos = db.Combos.ToList();
            return View(combos);
        }
    }
}