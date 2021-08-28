using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using stock.Models;
using System.Data.Odbc;
using System.Data;

namespace stock.DAO
{
    class FournisseurDAO
    {
        
        public static void save(Fournisseur fournisseur)
        {
            
            if (fournisseur.id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into fournisseur(nom,tel,code,adresse,date,etat)values(?,?,?,?,?,?)", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", fournisseur.nom);
                cmd.Parameters.AddWithValue("@b", fournisseur.tel);
                cmd.Parameters.AddWithValue("@c", fournisseur.code);
                cmd.Parameters.AddWithValue("@d", fournisseur.adresse);
                cmd.Parameters.AddWithValue("@f", fournisseur.date);
                cmd.Parameters.AddWithValue("@e", fournisseur.etat);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {

                OdbcCommand cmd = new OdbcCommand("update fournisseur set nom=?,tel=?,code=?,adresse=?,date=?,etat=?where id=?", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", fournisseur.nom);
                cmd.Parameters.AddWithValue("@b", fournisseur.tel);
                cmd.Parameters.AddWithValue("@c", fournisseur.code);
                cmd.Parameters.AddWithValue("@d", fournisseur.adresse);
                cmd.Parameters.AddWithValue("@d", fournisseur.date);
               
                cmd.Parameters.AddWithValue("@d", fournisseur.etat);
                cmd.Parameters.AddWithValue("e", fournisseur.id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public static void delete(int id)
        {

            OdbcCommand cmd = new OdbcCommand("delete from fournisseur where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Fournisseur find(int id)
        {
            Fournisseur fournisseur = null;
            OdbcCommand cmd = new OdbcCommand("select * from fournisseur where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
              fournisseur = new Fournisseur
                {
                    id = dr.GetInt32(0),
                    nom = dr.GetString(1),
                    code = dr.GetString(2),
                    tel = dr.GetString(3),
                    adresse = dr.GetString(4),
                    date = dr.GetDate(5),
                    etat = dr.GetString(6)
                };
            }

            return fournisseur;

        }

        public static List<Fournisseur> findAll()
        {

            List<Fournisseur> fournisseurs = new List<Fournisseur>();
            OdbcCommand cmd = new OdbcCommand("select id from fournisseur", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                fournisseurs.Add(find(dr.GetInt32(0)));
            }
            return fournisseurs;

        }

        public static List<Fournisseur> search(String nom)
        {
            List<Fournisseur> fournisseurs = new List<Fournisseur>();
            OdbcCommand cmd = new OdbcCommand("select id from fournisseur where nom like'%"+nom+"%'", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                fournisseurs.Add(find(dr.GetInt32(0)));
            }
            return fournisseurs;

        }
    }
    }

