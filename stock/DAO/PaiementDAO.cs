using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using stock.Models;
using System.Data.Odbc;

namespace stock.DAO
{
    class PaiementDAO
    {
        Paiement paiement=new Paiement();
        public static void save(Paiement paiement) {

            if (paiement.id == 0)
            {

                OdbcCommand cmd = new OdbcCommand("insert into paiement(libelle,date)values(?,?)", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", paiement.libelle);
                cmd.Parameters.AddWithValue("@b", paiement.date);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else {

                OdbcCommand cmd = new OdbcCommand("update paiement set libelle=?", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", paiement.libelle);
                cmd.Parameters.AddWithValue("@b", paiement.date);
                cmd.Parameters.AddWithValue("@b", paiement.id);
              
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            
            
            
            }
    
    
    }
        public static void delete(int id) {
            OdbcCommand cmd = new OdbcCommand("delete from paiement where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        
        
        }

        public static Paiement find(int id)
        {
            Paiement paiement = null;
            OdbcCommand cmd = new OdbcCommand("select * from paiement where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                paiement = new Paiement
                {
                    id = dr.GetInt32(0),
                    libelle = dr.GetString(1),
                    date = dr.GetDate(2),
                    
                };
            }

            return paiement;

        }
        public static List<Paiement> findAll()
        {

            List<Paiement> paiements = new List<Paiement>();
            OdbcCommand cmd = new OdbcCommand("select id from paiement", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                paiements.Add(find(dr.GetInt32(0)));
            }
            return paiements;

        }

    }
}
