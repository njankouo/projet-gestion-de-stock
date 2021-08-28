using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using stock.DAO;
using stock.Models;

using System.Windows.Forms;

namespace stock.Vues
{
    public partial class ajoutpersonnel : Form
    {
        Personnel personnel = new Personnel();
        public ajoutpersonnel()
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
            personnel.id = id;
            personnel.nom = txtnom.Text;
           personnel.tel= txttel.Text;

          personnel.adresse = txtadresse.Text;
           personnel.date = dtdate.Value;
           personnel.magasin = MagasinDAO.findid(cbmagasin.Text);
           personnel.etat = chketat.Text;

        }
        public void loadMagasin() {
            List<Magasin> magasins = MagasinDAO.findAll();
            cbmagasin.Items.Clear();
            foreach (Magasin magasin in magasins) {
                cbmagasin.Items.Add(magasin.nom);
            
            
            }
        }
        private void ajoutpersonnel_Load(object sender, EventArgs e)
        {
            loadCustomers();
            loadMagasin();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnom.Text == "" || txtnom.Text == "" || txtadresse.Text == "" || txttel.Text == "")
            {

                MessageBox.Show("erreur veuillez renseigner tous vos champs");
            }

            else if (id == 0)
            {

                formToModel();
                PersonnelDAO.save(personnel);
                txtnom.Text = "";
                txttel.Text = "";
                
                txtadresse.Text = "";
                chketat.Text = "";

                MessageBox.Show("enregistre avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                formToModel();
                PersonnelDAO.save(personnel);
                txtnom.Text = "";
                txttel.Text = "";
                //txttel.Text = "";
                txtadresse.Text = "";
                chketat.Text = "";


                MessageBox.Show("modifier avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
           
        }
        public void loadCustomers()
        {
            foreach (Magasin magasin in MagasinDAO.findAll())
            {
                cbmagasin.Items.Add(magasin);
            }
        }
        private void cbmagasin_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Magasin magasin = new Magasin();
           // Magasin magasin = null;
           // Magasin magasin = MagasinDAO.findtype(txtnom.Text);
            //txtnom.Text = magasin.nom;
           
        }

        private void txtadresse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
