using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi002.Data.Model
{
    public class CustomerInfo
    {

        public int id { get; set; }
        public string name { get; set; }
        public string lname { get; set; }
        public string address { get; set; }
        public string? city { get; set; }
        public DateTime? birthday { get; set; }
        //public int producksjonsplassid { get; set; }
        //public int? kommunenummer { get; set;  }
        //public int gaardsnummer { get; set; }
        //public int bruksnummer { get; set; }
        //public int  bygningsnummer { get; set; }
        //public string koordinater { get; set; }
        //public string koordinatsystem { get; set; }
        //public DateTime? opretterdato { get; set; }
        //public DateTime? lastchanged { get; set; }

    }
}

//public int id { get; set; }
//public string name { get; set; }
//public string lname { get; set; }
//public string address { get; set; }
//public string? city { get; set; }
//public DateTime? birthday { get; set; }