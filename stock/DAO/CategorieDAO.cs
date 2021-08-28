using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using stock.Models;

namespace stock.DAO
{

    class CategorieDAO
    {
        //Categorie cat = new Categorie();
        public static void save(Categorie cat)
        {
            if (cat.id == 0)
            {

                OdbcCommand cmd = new OdbcCommand("insert into categorie(libelle)values(?)", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", cat.libelle);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            else
            {


                OdbcCommand cmd = new OdbcCommand("update categorie set libelle=? where id=?", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", cat.libelle);
                cmd.Parameters.AddWithValue("@b", cat.id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();


            }


        }
        public void delete(int id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from categorie where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }

        public static Categorie find(int id)
        {

            Categorie categorie = null;
            OdbcCommand cmd = new OdbcCommand("select * from categorie where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categorie = new Categorie
                {
                    id = dr.GetInt32(0),
                    libelle = dr.GetString(1)

                };
            }
            return categorie;
        }

        public static List<Categorie> findAll()
        {

            List<Categorie> categories = new List<Categorie>();
            OdbcCommand cmd = new OdbcCommand("select id from categorie", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                categories.Add(find(dr.GetInt32(0)));
            }
            return categories;

        }
        public static List<Categorie> search(String libelle)
        {
            List<Categorie> categories = new List<Categorie>();
            OdbcCommand cmd = new OdbcCommand("select id from categorie where libelle like'%" + libelle + "%'", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                categories.Add(find(dr.GetInt32(0)));
            }
            return categories;

        }
        public static Categorie findtype(string libelle)
        {
            Categorie categorie = null;
            OdbcCommand cmd = new OdbcCommand("select id from categorie where libelle=?", BDD.connexion());
            cmd.Parameters.Add("@libelle", OdbcType.VarChar).Value = libelle;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categorie = find(dr.GetInt32(0));
            }
            return categorie;
        }

    }
}
