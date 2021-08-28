using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using stock.Models;
using stock.DAO;
namespace stock.DAO
{
    class PersonnelDAO
    {
        Personnel personnel = new Personnel();
         public static void save(Personnel personnel) {
             Magasin magasin=new Magasin();
            if (personnel.id == 0)
            {

                OdbcCommand cmd = new OdbcCommand("insert into personnel(nom,tel,adresse,date,idmagasin,etat)values(?,?,?,?,?,?)", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", personnel.nom);
                cmd.Parameters.AddWithValue("@b", personnel.tel);

                cmd.Parameters.AddWithValue("@c", personnel.adresse);
                cmd.Parameters.AddWithValue("@d", personnel.date);
                cmd.Parameters.AddWithValue("@e", personnel.magasin.id);
         
                cmd.Parameters.AddWithValue("@f", personnel.etat);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else {
                OdbcCommand cmd = new OdbcCommand("update personnel set nom=?,tel=?,adresse=?,date=?,idmagasin=?,etat=? where id=?", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", personnel.nom);
                cmd.Parameters.AddWithValue("@b", personnel.tel);

                cmd.Parameters.AddWithValue("@d", personnel.adresse);
                cmd.Parameters.AddWithValue("@f", personnel.date);
                cmd.Parameters.AddWithValue("@e", personnel.etat);
                cmd.Parameters.AddWithValue("@e", personnel.magasin.id);
                cmd.Parameters.AddWithValue("@e", personnel.id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            
            }
        }


        public static Personnel find(int id)
        {
            Personnel personnel = null;
            OdbcCommand cmd = new OdbcCommand("select * from personnel where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                personnel = new Personnel
                {
                    id = dr.GetInt32(0),
                    nom = dr.GetString(1),
                    
                    tel = dr.GetString(2),
                    adresse = dr.GetString(3),
                    date = dr.GetDate(4),
                    magasin = MagasinDAO.find(dr.GetInt32(5)),
                    etat = dr.GetString(6)
                };
            }

            return personnel;

        }

        public static List<Models.Personnel> findAllmagasin(string clt)
        {
          
            List<Models.Personnel> personnels = new List<Models.Personnel>();
            OdbcCommand cmd = new OdbcCommand("select * from personnel, magasin where magasin.id = personnel.idmagasin and magasin.nom=?", BDD.connexion());
            cmd.Parameters.Add("@id", OdbcType.VarChar).Value = clt;
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                personnels.Add(find(dr.GetInt32(0)));
            }
            cmd.Dispose();
            return personnels;
        }
        public static List<Personnel> findAll()
        {

            List<Personnel> personnels = new List<Personnel>();
            OdbcCommand cmd = new OdbcCommand("select id from personnel", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                personnels.Add(find(dr.GetInt32(0)));
            }
            return personnels;

        }
    }
}
