using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stock.Models
{
    class Produit
    {
        public int id { get; set; }
        public string nom { get; set; }
        public Categorie libelle { get; set; }
        public string pu { get;set; }
        
    }
}
