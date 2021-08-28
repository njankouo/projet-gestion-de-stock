using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stock.DAO;
using stock.Vues;
using System.Data.Odbc;

namespace stock.Vues
{
    public partial class frmconnexion : Form
    {
        public frmconnexion()
        {
            InitializeComponent();
        }
        frmhome fr = new frmhome();
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            OdbcCommand cmd = new OdbcCommand("select * from login where username='"+txtusername.Text +"' and password='"+txtpassword.Text+"'",BDD.connexion());
            OdbcDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                fr.Show();
                this.Hide();
            }
            else {

                MessageBox.Show("username and password not match","information",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
            reader.Close();
            cmd.Dispose();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              
               
            
         
        }

        private void frmconnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
