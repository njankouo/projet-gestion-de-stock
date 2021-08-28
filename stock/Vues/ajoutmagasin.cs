using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using stock.Models;
using stock.DAO;
using stock.Vues;
using System.Windows.Forms;

namespace stock.Vues
{
    public partial class ajoutmagasin : Form
    {
        public ajoutmagasin()
        {
            InitializeComponent();
        }

        Magasin magasin=new Magasin();
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }
         public void formToModel()
        {
            magasin.id = id;
            magasin.nom = txtnom.Text;
            
            magasin.date = dtdate.Value;
            magasin.etat = chketat.Text;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
              if (txtnom.Text == "")
            {

                MessageBox.Show("erreur veuillez renseigner tous vos champs");
            }
              else if (id == 0)
              {

                  formToModel();
                  MagasinDAO.save(magasin);
                  txtnom.Text = "";

                  MessageBox.Show("enregistre avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }

              else {

                  formToModel();
                  MagasinDAO.save(magasin);
                  txtnom.Text = "";

                  MessageBox.Show("modifier  avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
              
              
              }
        }
        

        private void btnannuler_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
           
        }

        private void ajoutmagasin_Load(object sender, EventArgs e)
        {

        }
    }
}
