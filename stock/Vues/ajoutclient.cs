using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stock.DAO;
using stock.Models;

namespace stock.Vues
{
    public partial class ajoutclient : Form
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public ajoutclient()
        {
            InitializeComponent();
        }
        Client client = new Client();
        public void formToModel()
        {

            client.nom = txtnom.Text;
            
            client.tel = txttel.Text;
            client.adresse = txtadresse.Text;
            client.date = dtdate.Value;
            client.etat = chketat.Text;
            client.id = id;

        }
        public void vider()
        {
            txtnom.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnom.Text == "" || txttel.Text == "" || txtadresse.Text == "")
            {

                MessageBox.Show("erreur veuillez renseigner tous vos champs");
            }
            else
            {
                if(id==0){
                    formToModel();
                    ClientDAO.save(client);
                    txtnom.Text = "";
                    txttel.Text = "";
                    txtadresse.Text = "";

                    MessageBox.Show("enregistre avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else{
                    formToModel();
                    ClientDAO.save(client);
                    txtnom.Text = "";
                    txttel.Text = "";
                    txtadresse.Text = "";

                    MessageBox.Show("modification avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //    Regex r = new Regex(@"^[0-9]{10}$");
            //    if (r.IsMatch(txttel.Text))
            //    {

            //    }
            //    else {
            //        MessageBox.Show("invalid telephone");


            //}

        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txttel.Text = "";
            txtadresse.Text = "";
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajoutclient_Load(object sender, EventArgs e)
        {

        }
    }
}
