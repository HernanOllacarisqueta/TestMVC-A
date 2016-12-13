using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVC.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        //rodrigoreuil@gmail.com
        public ActionResult Index()
        {
            string mensaje = "Use the source Luke!!";

            //return View(model: mensaje);  //tomar como parametro una de las  5 sobrecargas, especificamos cual queremos (la mas directa).
            this.ViewData.Model = mensaje;
            return View();
        }
    }
}