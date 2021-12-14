using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechAcadStudentsMVC.Controllers   //para agregar este nuevo controlador en la carpeta de controllers del explorador
                                            //de soluciones di clic en agregar y luego escogi controlador, luego seleccione
                                            //vacio y renombre dejando al final sin separacion ( estilo camello) ej. => StudentsController
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
    }
}