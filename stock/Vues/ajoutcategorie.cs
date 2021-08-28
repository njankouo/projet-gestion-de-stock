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
namespace stock.Vues
{
    public partial class ajoutcategorie : Form
    {
        public ajoutcategorie()
        {
            InitializeComponent();
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        Categorie cat = new Categorie();
        private void FormtoModel() {

            cat.libelle = txtlibelle.Text;
            cat.id = Id;
        }

        private void ajoutcategorie_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtlibelle.Text == "")
            {
                MessageBox.Show("Veuillez renseigner ce champ");

            }

            else if (id == 0)
            {
                FormtoModel();
                CategorieDAO.save(cat);
                txtlibelle.Text = "";
                MessageBox.Show("enregistré avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else {

                FormtoModel();
                CategorieDAO.save(cat);
                txtlibelle.Text = "";
                MessageBox.Show("Modifié avec success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            txtlibelle.Text = "";
        }

        private void txtlibelle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
