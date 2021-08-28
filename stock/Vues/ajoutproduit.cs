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
    public partial class ajoutproduit : Form
    {
        public ajoutproduit()
        {
            InitializeComponent();
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        Produit produit = new Produit();

        public void formToModel()
        {

            produit.nom = txtnom.Text;

            produit.pu = txtpu.Text;
            produit.libelle =CategorieDAO.findtype(cblibelle.Text);
            produit.id = id;
            
        }
        public void loadProduit()
        {
            List<Categorie> categories = CategorieDAO.findAll();
            cblibelle.Items.Clear();
            foreach (Categorie categorie in categories)
            {
                cblibelle.Items.Add(categorie.libelle);


            }
        }
        private void ajoutproduit_Load(object sender, EventArgs e)
        {
            loadProduit();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnom.Text == "" || txtpu.Text=="")
            {

                MessageBox.Show("erreur veuillez renseigner tous vos champs");
            }
            else
            {
                if (id == 0)
                {

                    formToModel();
                    ProduitDAO.save(produit);
                    txtnom.Text = "";
                    txtpu.Text = "";

                    MessageBox.Show("enregistre avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    formToModel();
                    ProduitDAO.save(produit);
                    txtnom.Text = "";
                    txtpu.Text = "";

                    MessageBox.Show("modification success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                
                }
                }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            txtnom.Text="";
            txtpu.Text = "";
        }
    }
}
