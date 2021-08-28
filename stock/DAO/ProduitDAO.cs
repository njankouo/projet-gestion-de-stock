using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using stock.Models;
namespace stock.DAO
{
    class ProduitDAO
    {
        Produit produit = new Produit();
        public static void save(Produit produit) {
            if (produit.id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into produit(nom,idproduit,pu)values(?,?,?)", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", produit.nom);
                cmd.Parameters.AddWithValue("@b", produit.pu);
             
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            else {

                OdbcCommand cmd = new OdbcCommand("update produit set nom=?,idproduit,pu=? where id=?", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", produit.nom);
                cmd.Parameters.AddWithValue("@a", produit.pu);
                
                cmd.Parameters.AddWithValue("@a", produit.id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            
            
            }
        
        
        }


        public static Produit find(int id)
        {
            Produit produit = null;
            OdbcCommand cmd = new OdbcCommand("select * from produit where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                produit = new Produit
                {
                    id = dr.GetInt32(0),
                    nom = dr.GetString(1),
                    pu = dr.GetString(2),
                    

                };
            }

            return produit;

        }
        public static List<Produit> findAll()
        {

            List<Produit> produits = new List<Produit>();
            OdbcCommand cmd = new OdbcCommand("select id from produit", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                produits.Add(find(dr.GetInt32(0)));
            }
            return produits;

        }
        public static List<Produit> search(String nom)
        {
            List<Produit> produits = new List<Produit>();
            OdbcCommand cmd = new OdbcCommand("select id from produit where nom like'%" + nom + "%'", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                produits.Add(find(dr.GetInt32(0)));
            }
            return produits;

        }
    }
}
