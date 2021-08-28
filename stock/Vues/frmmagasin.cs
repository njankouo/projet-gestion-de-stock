using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stock.Models;
using stock.DAO;
using stock.Vues;

namespace stock.Vues
{
    public partial class frmmagasin : Form
    {
        public frmmagasin()
        {
            InitializeComponent();
        }
        ajoutmagasin ajout = new ajoutmagasin();
        Magasin mag = new Magasin();
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ajoutmagasin ma = new ajoutmagasin();
            ma.Show();
        }
        public void loadCustomers()
        {
            List<Magasin> magasins = MagasinDAO.findAll();
            dgmagasin.Rows.Clear();
            foreach (Magasin magasin in magasins)
            {
                dgmagasin.Rows.Add(new string[] { magasin.id.ToString(), magasin.nom, magasin.date.ToString(), magasin.etat });
            }
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
        public void modelToForm()
        {
            ajoutmagasin magasin = new ajoutmagasin();
            magasin.Id = mag.id;
            magasin.Txtnom.Text = mag.nom;
            magasin.Dtdate.Value = mag.date;
            magasin.Chketat.Text = mag.etat;
            magasin.Show();

        }


     
        private void frmmagasin_Load(object sender, EventArgs e)
        {
            loadCustomers();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            List<Magasin> magasins = MagasinDAO.search(txtsearch.Text);
            dgmagasin.Rows.Clear();
            foreach (Magasin magasin in magasins)
            {
                dgmagasin.Rows.Add(new string[] { magasin.id.ToString(), magasin.nom,magasin.date.ToString(), magasin.etat });

            }


        }

        private void dgmagasin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dgmagasin.CurrentRow.Cells[0].Value.ToString());
            mag = MagasinDAO.find(id);
            modelToForm();
        }

        private void dgmagasin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}