using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stock.Vues;
using  stock.Models;
using stock.DAO;
using System.Data.Odbc;

namespace stock.Vues
{
    public partial class frmFournisseur : Form
    {
        Fournisseur four = new Fournisseur();
        ajoutfournisseur fournisseur = new ajoutfournisseur();

           public frmFournisseur()
        {

            InitializeComponent();
          
        }
          
         
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmFournisseur_Load(object sender, EventArgs e)
        {
            loadCustomers();
        }

        public void loadCustomers()
        {
            List<Fournisseur> fournisseurs = FournisseurDAO.findAll();
            dgfournisseur.Rows.Clear();
            foreach (Fournisseur fournisseur in fournisseurs)
            {
                dgfournisseur.Rows.Add(new string[]{fournisseur.id.ToString(),fournisseur.nom,fournisseur.code,fournisseur.tel,fournisseur.adresse,fournisseur.etat});
            }
        }
        public void modelToForm()
        {
            ajoutfournisseur fournisseur = new ajoutfournisseur();
            fournisseur.Id = four.id;
             fournisseur.Txtnom.Text = four.nom;
            fournisseur.Txtcode.Text = four.code;
             fournisseur.Txttel.Text = four.tel;
             fournisseur.Txtadresse.Text = four.adresse;
            fournisseur.Chketat.Text = four.etat;
         
            fournisseur.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            ajoutfournisseur four = new ajoutfournisseur();
            four.Show();
        }

        private void dgfournisseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dgfournisseur.CurrentRow.Cells[0].Value.ToString());
            four = FournisseurDAO.find(id);
            modelToForm();
            
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Refresh();
            loadCustomers();
                 
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            List<Fournisseur> fournisseurs = FournisseurDAO.search(txtsearch.Text);
            dgfournisseur.Rows.Clear();
            foreach (Fournisseur fournisseur in fournisseurs)
            {
                dgfournisseur.Rows.Add(new string[] { fournisseur.id.ToString(), fournisseur.nom, fournisseur.code, fournisseur.tel,fournisseur.adresse, fournisseur.etat });
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("are you sure to delete row?", "confirmation", MessageBoxButtons.YesNo);
            //if (dr == DialogResult.Yes) {
            //    int id = Int32.Parse(dgfournisseur.CurrentRow.Cells[0].Value.ToString());
            //    FournisseurDAO.delete(id);

            //    loadCustomers();

            //}
            //else if (DialogResult == DialogResult.No) {

            //    MessageBox.Show("aucune donnee n'a ete supprime");
            //}
          
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    } 
    

