using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stock.Vues;
using stock.Models;
using stock.DAO;
namespace stock.Vues
{
    public partial class frmproduit : Form
    {
        public frmproduit()
        {
            InitializeComponent();
        }
        ajoutproduit prod = new ajoutproduit();
        Produit produit = new Produit();
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ajoutproduit produit = new ajoutproduit();
            produit.Show();
        }
        public void loadCustomers()
        {
            List<Produit> produits = ProduitDAO.findAll();
            dgproduit.Rows.Clear();
            foreach (Produit produit in produits)
            {
                dgproduit.Rows.Add(new string[] { produit.id.ToString(), produit.nom,produit.libelle.ToString(),produit.pu });
            }
        }

        private void dgpaiement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmproduit_Load(object sender, EventArgs e)
        {
            loadCustomers();
        }
        public void modelToForm()
        {
            // modifPaiement mod = new modifPaiement();
            ajoutproduit prod = new ajoutproduit();

            prod.Id = produit.id;
            prod.Txtnom.Text = produit.nom;
           
            prod.Txtpu.Text = produit.pu;

            
         
            // mod.Txtlibelle.Text = p.libelle;
            //ceci permet de recuperer les elements de la zone de texte pour la modification
            prod.Show();
        }
        private void dgproduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dgproduit.CurrentRow.Cells[0].Value.ToString());
            produit = ProduitDAO.find(id);
            modelToForm();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            loadCustomers();
            this.Refresh();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            List<Produit> produits = ProduitDAO.search(txtsearch.Text);
            dgproduit.Rows.Clear();
            foreach (Produit produit in produits)
            {
                dgproduit.Rows.Add(new string[] { produit.id.ToString(), produit.nom, produit.pu });
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
         

        }
    }
}
