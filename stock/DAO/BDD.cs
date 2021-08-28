using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace stock.DAO
{
    class BDD
    {
        private static OdbcConnection connex = null;
        public static OdbcConnection connexion() {

            if (connex == null) {

                 connex = new OdbcConnection("dsn=stock");
                 connex.Open();
            }
            return connex;
        }
    }
}
