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
using stock.DAO;
using stock.Models;
namespace stock.Vues
{
    public partial class frmpersonnel : Form
    {
        public frmpersonnel()
        {
            InitializeComponent();
        }
        ajoutpersonnel personnel = new ajoutpersonnel();
        Personnel personne = new Personnel();
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ajoutpersonnel personnel = new ajoutpersonnel();
            personnel.Show();
        }


        public void loadMagasin()
        {
            List<Magasin> magasins = MagasinDAO.findAll();
            
        }
        public void loadCustomers()
        {
            List<Personnel> personnels = PersonnelDAO.findAll();
            dgpersonnel.Rows.Clear();
            foreach (Personnel personnel in personnels)
            {
                dgpersonnel.Rows.Add(new string[] { personnel.id.ToString(), personnel.nom, personnel.tel,personnel.adresse,personnel.date.ToString(), personnel.magasin.nom,personnel.etat });
            }
        }
        public void modelToForm()
        {
            
            personnel.Id = personne.id;
            personnel.Txtnom.Text = personne.nom;
            personnel.Txttel.Text = personne.tel;
            personnel.Txtadresse.Text = personne.adresse;
           
            personnel.Dtdate.Value = personne.date;
            personnel.Cbmagasin.Text =personne.magasin.nom;    
            personnel.Chketat.Text = personne.etat;
            personnel.Show();

        }

        private void dgmagasin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dgpersonnel.CurrentRow.Cells[0].Value.ToString());
            personne = PersonnelDAO.find(id);
            modelToForm();
        }

        private void dgmagasin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmpersonnel_Load(object sender, EventArgs e)
        {
            loadCustomers();
            loadMagasin();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            loadCustomers();
            this.Refresh();

        }
    }
}
