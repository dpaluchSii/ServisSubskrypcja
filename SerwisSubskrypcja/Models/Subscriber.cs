using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerwisSubskrypcja.Models
{
    public class Subscriber
    {
        [ScaffoldColumn(false)]
        public long  Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}