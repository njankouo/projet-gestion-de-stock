using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using stock.Vues;
using stock.Models;
using stock.DAO;
using System.Windows.Forms;

namespace stock.Vues
{
    public partial class frmcategorie : Form
    {
        public frmcategorie()
        {
            InitializeComponent();
        }
        ajoutcategorie cate = new ajoutcategorie();
        Categorie cater = new Categorie();

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ajoutcategorie cat = new ajoutcategorie();
            cat.Show();

        }
        public void loadCustomers()
        {
            List<Categorie> categories = CategorieDAO.findAll();
            dgcategorie.Rows.Clear();
            foreach (Categorie categorie in categories)
            {
                dgcategorie.Rows.Add(new string[] { categorie.id.ToString(), categorie.libelle});
            }
        }
        private void modeltoform() {
            ajoutcategorie cate = new ajoutcategorie();
            cate.Id = cater.id;
           cate.Txtlibelle.Text = cater.libelle;
           cate.Show();
        
        }

        private void frmcategorie_Load(object sender, EventArgs e)
        {
            loadCustomers();
        }

        private void dgcategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dgcategorie.CurrentRow.Cells[0].Value.ToString());
            cater = CategorieDAO.find(id);
            modeltoform();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Refresh();
            loadCustomers();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            List<Categorie> categories = CategorieDAO.search(txtsearch.Text);
            dgcategorie.Rows.Clear();
            foreach (Categorie categorie in categories)
            {
                dgcategorie.Rows.Add(new string[] { categorie.id.ToString(), categorie.libelle });
            }
   
        }

        private void dgcategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
