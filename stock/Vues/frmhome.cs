using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stock.Vues;


namespace stock.Vues
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            frmFournisseur fourniss = new frmFournisseur();
            fourniss.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            frmmagasin fm = new frmmagasin();
            fm.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            FrmClient fou = new FrmClient();
            fou.Show();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            frmpaiement fn = new frmpaiement();
            fn.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmproduit fh = new frmproduit();
            fh.Show();
        }

        private void gunaButton13_Click(object sender, EventArgs e)
        {
            frmpersonnel fg = new frmpersonnel();
            fg.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            frmcategorie fj = new frmcategorie();
            fj.Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            frmcommande fk = new frmcommande();
            fk.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            frmvente js = new frmvente();
            js.Show();
        }
    }
}
