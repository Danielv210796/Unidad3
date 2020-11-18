using PracticaSemanal1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaSemanal1.Controllers
{
    public class CineController : Controller
    {
        readonly CineDbConnection db = new CineDbConnection();
        // GET: Cine
        public ActionResult Index()
        {
            //Agregamos una variable  y se retorna con el RETURN VIEW
            var cines = db.Cines.ToList();
            //SELECT * FROM  cines
            return View(cines);
        }

        //agregamos un metodo de delete
        //asignamos como parametro el id
        //Lo va eliminar todo el registro
        public ActionResult Delete(int id)
        {
            
            var cine = db.Cines.Find(id);
            //select * from  cines  where cines.Id=id
            return View();
        }
    }
}