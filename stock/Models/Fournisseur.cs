using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data;
namespace stock.Models
{
    class Fournisseur
    {
        public int id { get; set; }
        public string nom { get; set; }
        public String tel { get; set; }
        public string code { get; set; }
        public string adresse { get; set; }
        public string etat { get; set; }
        public DateTime date { get; set; }

    }
}
