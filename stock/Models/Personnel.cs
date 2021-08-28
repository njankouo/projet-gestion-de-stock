using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;

namespace stock.Models
{
    class Personnel
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string tel { get; set; }
        public string adresse { get; set; }
        public DateTime date { get; set; }
        public Magasin magasin { get; set; }
        public String etat { get; set; }
    }
}
