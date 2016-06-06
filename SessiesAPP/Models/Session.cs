using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessiesAPP.Models
{
    public class Session
    {
        public int ID { get; set; }
        public string title { get; set; }
        public int attendees { get; set; }
    }
}