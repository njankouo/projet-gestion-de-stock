using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stock.Vues;
using System.Data.Odbc;
using stock.Models;
using stock.DAO;
namespace stock.Vues
{
    public partial class frmpaiement : Form
    {
        public frmpaiement()
        {
            InitializeComponent();
        }
        Paiement p = new Paiement();
        ajoutpaiement add = new ajoutpaiement();

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ajoutpaiement paie = new ajoutpaiement();
            paie.Show();
        }
        private void frmpaiement_Load(object sender, EventArgs e)
        {
            loadCustomers();
        }
        public void loadCustomers()
        {
            List<Paiement> paiements = PaiementDAO.findAll();
            dgpaiement.Rows.Clear();
            foreach (Paiement paiement in paiements)
            {
                dgpaiement.Rows.Add(new string[] { paiement.id.ToString(), paiement.libelle});
            }
        }
      
        public void modelToForm()
        {
           // modifPaiement mod = new modifPaiement();
            ajoutpaiement paiement = new ajoutpaiement();
            paiement.Txtlibelle.Text = p.libelle;
           // mod.Txtlibelle.Text = p.libelle;
          //ceci permet de recuperer les elements de la zone de texte pour la modification
           paiement.Show();
        }

        private void dgpaiement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dgpaiement.CurrentRow.Cells[0].Value.ToString());
            p = PaiementDAO.find(id);
            modelToForm();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Refresh();
            loadCustomers();
        }

       
    }
}
