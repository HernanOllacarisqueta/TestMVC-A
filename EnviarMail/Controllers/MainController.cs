using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EnviarMail.Models;
using System.Net.Mail;

namespace EnviarMail.Controllers
{
    public class MainController : ApiController
    {  
        public string Test(string token)
        {
            if (token == "12345678")
                 return "OK";

            throw new HttpResponseException(HttpStatusCode.BadRequest);
        }

        public IHttpActionResult Send(MainDefinicion mail)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                MailMessage correo = new MailMessage();

                //Adaptamos nuestro MainDefinicion a MailMessage que entiende SmtpClient

                correo.From = new MailAddress("asisos_automaticos@mutex.com.ar", mail.From);
                correo.Subject = mail.Subject;
                correo.Body = mail.Body;
                foreach (string s in mail.To)
                {
                    correo.To.Add(s);
                }
                //Configuramos servidor SMTP
                smtp.Host = "localhost";
                smtp.Credentials = new NetworkCredential("", "");
                //smtp.Port=  Agregar el puerto smtp si es necesario.
                
                smtp.Send(correo);
                return Ok("correo enviado");


                //{
                //  "From" : "Sarasa@sarasa.com.ar",
                //  "To" : ["ethedy@gmail.com" , "hernan.ollacarisqueta@gmail.com"],
                //  "Subject" : "Prueba",
                //  "Body" : "heloooo"
                //}


}
            catch(Exception ex)
            {
                return Json(ex);

            }

        }
    }
}
