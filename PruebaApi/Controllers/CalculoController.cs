using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebaApi.Controllers
{
    public class CalculoController : ApiController
    {
        [HttpGet]
        //La respuesta que va a devolver al cliente es un entero.
        public int Suma(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
