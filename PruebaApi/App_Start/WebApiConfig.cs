using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PruebaApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                //routeTemplate: "api/{controller}/{id}", //No hay un directorio llamado "api", pero si hay que redireccionarlo  con "api/....".
                /* //EN POSTMAN: http://localhost:50930/api/calculo/Suma/10/20
                routeTemplate: "api/{controller}/{action}/{n1}/{n2}" */ //OPCION 1

                //OPCION 2, EN POSTMAN  http://localhost:50930/api/calculo/Suma, key=n1, value=10, key=n2, value=20
                routeTemplate: "api/{controller}/{action}" 

            //defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
