using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;

namespace stock.Models
{
    class Paiement
    {
        public int id { get; set; }
        public string libelle { get; set; }
        public DateTime date { get; set; }
    }
}
