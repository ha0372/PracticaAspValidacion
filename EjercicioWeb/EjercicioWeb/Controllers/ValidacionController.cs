using EjercicioWeb.DAORe;
using EjercicioWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioWeb.Controllers
{
    public class ValidacionController : Controller
    {
        // GET: Validacion


        public ActionResult VistaValidacion()
        {
            return View();
        }

        public ActionResult Validacion(string nombre, string dui)
        {
            //ClsEmpleado log = new ClsEmpleado();
            EmpleadosRe Cls = new EmpleadosRe();

            //int confirmacion;

            for (int i = 0; i < Cls.user.Length; i++)
            {
                if (nombre.Equals(Cls.user[i]) && dui.Equals(Cls.dui[i]))
                    
                {
                    return Redirect("/Validacion/Datos");
                }
                
            }


            return Redirect("/Validacion/VistaValidacion");
        }

        public ActionResult Datos()
        {
            return View();
        }

    }
}