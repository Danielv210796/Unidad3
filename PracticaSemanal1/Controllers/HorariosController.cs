using PracticaSemanal1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaSemanal1.Controllers
{
    public class HorariosController : Controller
    {
        //solo lectura
        readonly HorarioDbConnection db = new HorarioDbConnection();

        // GET: Horarios
        public ActionResult Index()
        {
            var horarios = db.Horarios.ToList();
            //select * from horarios 
            return View(horarios);

        }
        //---------------------------------------------CREATE--------------------------------//
        //GET: EJEMPLO
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Horarios horario)
        {
            db.Horarios.Add(horario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //---------------------------------------------DELETE--------------------------------//
        public ActionResult Delete(int id)
        {
        
            var horario = db.Horarios.Find(id); /*lambdas*/
            return View(horario);
        }
        [HttpPost]
        public ActionResult Delete(int id,Horarios c)
        {
            try
            {
                var horario = db.Horarios.Find(id);
                db.Horarios.Remove(horario);
                db.SaveChanges();
                
            }
            catch
            {
                
            }
            return RedirectToAction("Index");

        }

        //---------------------------------------------DETALLES--------------------------------//

        //METODO DE VISTA DE DETALLES
        public ActionResult Details(int id)
        {
            var Horario = db.Horarios.Find(id);
            return View(Horario);
        }

        //---------------------------------------------EDITAR--------------------------------//

        //METODO GET
        public ActionResult Edit(int id)
        {
            var Horario = db.Horarios.Find(id);
            return View(Horario);
        }
        
        [HttpPost]
        public ActionResult Edit(int id,Horarios c)
        {
            try
            {
               //VA MOSTRAR EL ID DE LAS VARIABLES
                var Horario = db.Horarios.Find(id);

              //VARIABLES A EDITAR
                Horario.Nombre = c.Nombre;
                Horario.Hora = c.Hora;
                db.SaveChanges();
               
            }
            catch
            {
              
            }
            return RedirectToAction("Index");
        }
    }
}