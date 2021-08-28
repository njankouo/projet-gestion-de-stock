using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;

namespace stock.Models
{
    class Magasin
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string etat { get; set; }
        public DateTime date { get; set; }
    }
}
