using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PracticaSemanal1.Models
{
    public class CineDbConnection:DbContext
    {
        // SE CREO PARA REGULAR LA CONEXION A LA BASE DE DATOS
        public CineDbConnection() : base("cinedb")
        {

        }
        //CREACION DE CONSTRUCTORES
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        //AGREGAR EL DbSet Se le asigna ---->   < > el nombre del controlador.
        //Registramos las tablas que queramos en nuestra Database.
        public DbSet<Cines> Cines { get; set; }
        public DbSet<Combos> Combos { get; set; }
    }
}