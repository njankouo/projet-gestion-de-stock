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
    public partial class ajoutpaiement : Form
    {
        Paiement paiement = new Paiement();
        public ajoutpaiement()
        {
            InitializeComponent();
        }
        public void FormToModel() {

            paiement.libelle = txtlibelle.Text;
            paiement.date = dtdate.Value;    
        
        }
        public void vider() {

            txtlibelle.Focus();
        
        }


        private void ajoutpaiement_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
             if(txtlibelle.Text==""){

                MessageBox.Show("erreur veuillez renseigner tous vos champs");
            }else{

                FormToModel();
                PaiementDAO.save(paiement);
                txtlibelle.Text = "";
                
                 MessageBox.Show("enregistre avec success","information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
           
        }
        }
    }

