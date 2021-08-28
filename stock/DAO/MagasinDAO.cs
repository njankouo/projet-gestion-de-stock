using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using stock.Models;
using System.Data.Odbc;

namespace stock.DAO
{
    class MagasinDAO
    {
        Magasin magasin = new Magasin();
        public static void save(Magasin magasin) {
            if (magasin.id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into magasin(nom,date,etat)values(?,?,?)", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", magasin.nom);
                cmd.Parameters.AddWithValue("@b", magasin.date);
                cmd.Parameters.AddWithValue("@b", magasin.etat);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else {
                OdbcCommand cmd = new OdbcCommand("update magasin set nom=?,date=? where id=?", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", magasin.nom);
                cmd.Parameters.AddWithValue("@b", magasin.date);
                cmd.Parameters.AddWithValue("@c", magasin.id);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
       
            }
        
        }
        public static void delete(int id) {
            OdbcCommand cmd = new OdbcCommand("delete from magasin where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
             cmd.ExecuteNonQuery();
            cmd.Dispose();
       
        }

        public static Magasin findid(string nom)
        {
            Magasin magasin = null;
            OdbcCommand cmd = new OdbcCommand("select id from magasin where nom=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", nom);
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                magasin = new Magasin() { id = dr.GetInt32(0)};
            }
            cmd.Dispose();
            dr.Close();
            return magasin;
        }

        public static Magasin find(int id)
        {
            Magasin magasin = null;
            OdbcCommand cmd = new OdbcCommand("select * from magasin where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                magasin = new Magasin
                {
                    id = dr.GetInt32(0),
                    nom = dr.GetString(1),
                    date = dr.GetDateTime(2),
                    etat = dr.GetString(3)
                };
            }

            return magasin;
        }



        public static List<Magasin> findAll()
        {

            List<Magasin> magasins = new List<Magasin>();
            OdbcCommand cmd = new OdbcCommand("select id from magasin", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                magasins.Add(find(dr.GetInt32(0)));
            }
            return magasins;

        }

        public static List<Magasin> search(String nom)
        {
            List<Magasin> magasins = new List<Magasin>();
            OdbcCommand cmd = new OdbcCommand("select id from magasin where nom like'%" + nom + "%'", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                magasins.Add(find(dr.GetInt32(0)));
            }
            return magasins;

        }
        public static Magasin findtype(string nom)
        {
            Magasin magasin = null;
            OdbcCommand cmd = new OdbcCommand("select id from magasin where nom=?", BDD.connexion());
            cmd.Parameters.Add("@nom", OdbcType.VarChar).Value = nom;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                magasin = find(dr.GetInt32(0));
            }
            return magasin;
        }
    }
}
