using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using stock.Vues;
using stock.Models;
using stock.DAO;
using System.Data;

namespace stock.DAO
{
    
    class ClientDAO
    {
        Client client=new Client();
        public static void save(Client client) {

            if (client.id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into client(nom,tel,adresse,date,etat)values(?,?,?,?,?)", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", client.nom);
                cmd.Parameters.AddWithValue("@b", client.tel);
                cmd.Parameters.AddWithValue("@c", client.adresse);
                cmd.Parameters.AddWithValue("@d", client.date);
                cmd.Parameters.AddWithValue("@e", client.etat);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else {


                OdbcCommand cmd = new OdbcCommand("update client set nom=?,tel=?,adresse=?,date=?,etat=? where id=?", BDD.connexion());
                cmd.Parameters.AddWithValue("@a", client.nom);
                cmd.Parameters.AddWithValue("@b", client.tel);
                cmd.Parameters.AddWithValue("@c", client.adresse);
                cmd.Parameters.AddWithValue("@d", client.date);
                cmd.Parameters.AddWithValue("@e", client.etat);
                cmd.Parameters.AddWithValue("@f", client.id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            
            }
        }
        public static void delete(int id) {


            OdbcCommand cmd = new OdbcCommand("delte from client where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        
        }

        public static Client find(int id){
            Client client = null;
            OdbcCommand cmd = new OdbcCommand("select * from client where id=?", BDD.connexion());
            cmd.Parameters.AddWithValue("@id", id);
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                client = new Client
                {
                    id = dr.GetInt32(0),
                    nom = dr.GetString(1),
                    tel = dr.GetString(2),
                    adresse = dr.GetString(3),
                    date = dr.GetDateTime(4),
                    etat = dr.GetString(5)
                };
            }

            return client;

        
        
        
        }

        public static List<Client> findAll()
        {

            List<Client> clients = new List<Client>();
            OdbcCommand cmd = new OdbcCommand("select id from client", BDD.connexion());
            OdbcDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                clients.Add(find(dr.GetInt32(0)));
            }
            return clients;

        }

    }
}
