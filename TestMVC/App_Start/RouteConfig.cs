using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestMVC
{
    public class RouteConfig
    {
        //RegisterRoutes le dice al RouteEngine como identificar las rutas de la URL. lo llama "Global.asax.cs"
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //el default especifica q se use el controlador "ProductosController" con la accion asosiada en "Productos\Index.cshtml"
                //esto se establecio en las propiedades del proyecto (en spesific page)
                defaults: new { controller = "Productos", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
