using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller  //hereda de la clase Controller, en la que estan definidos los metodos View()
                                              //y el pseudo-diccionario llamado ViewBag(), si le quitamos esta clase no reconocera los metodos
    {
        public ActionResult Index()     //este metodo (Index) no acepta parametros y su tipo de retorno es un tipo de datos llamado ActionResult
        {
            return View();              //ActionResult es una clase definida en la biblioteca System.Web.Mvc (es como HTML renderizado)
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();              //el metodo View es un metodo muy poderoso, observando el nombre del metodo del que se llama
                                        //(Index/About/Contact) y el nombre de la clase controlador (HomeController) puede encontrar
                                        //y procesar el archivo .cshtml apropiado (Index.cshtml).
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page - The Tech Academy.";

            return View();
        }

        public ActionResult Instructor(int id=7718094)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult Instructors()
        {
            return View();
        }
    }
}