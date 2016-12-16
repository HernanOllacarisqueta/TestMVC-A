using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnviarMail.Models
{
    public class MainDefinicion
    {
        public string From { get; set; }
        public List<string> To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public MainDefinicion()
        {
            To = new List<string>();

        }
    }
}