using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using stock.Models;
using stock.DAO;
using stock.Vues;
using System.Data.Odbc;
using System.Windows.Forms;

namespace stock.Vues
{
    public partial class ajoutfournisseur : Form
    {
          //private Fournisseur fournisseur = null;

          Fournisseur fournisseur = new Fournisseur();
        public ajoutfournisseur()
        {
            InitializeComponent();
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public void formToModel()
        {
            fournisseur.id = id;
            fournisseur.nom = txtnom.Text;
            fournisseur.code = txtcode.Text;

            fournisseur.tel = txttel.Text;
            fournisseur.adresse = txtadresse.Text;
            fournisseur.date = dtdate.Value;
            fournisseur.etat = chketat.Text;

        }
        public void vider()
        {
               txtnom.Focus();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
              if (txtnom.Text == "" || txtcode.Text == "" || txtadresse.Text == "" || txttel.Text == "")
            {

                MessageBox.Show("erreur veuillez renseigner tous vos champs");
            }

            else if (id == 0)
            {

                formToModel();
                FournisseurDAO.save(fournisseur);
                txtnom.Text = "";
                txtcode.Text = "";
                txttel.Text = "";
                txtadresse.Text = "";
                chketat.Text = "";

                MessageBox.Show("enregistre avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {


                formToModel();
                FournisseurDAO.save(fournisseur);
                txtnom.Text = "";
                txtcode.Text = "";
                txttel.Text = "";
                txtadresse.Text = "";
                chketat.Text = "";


                MessageBox.Show("modifier avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            
            
            
            }
           
           
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtcode.Text = "";
            txttel.Text = "";
            txtadresse.Text = "";
               
        }

        private void ajoutfournisseur_Load(object sender, EventArgs e)
        {

        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
