using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using stock.Vues;
using System.Windows.Forms;

namespace stock.Vues
{
    public partial class frmcommande : Form
    {
        public frmcommande()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ajoutcommande commande = new ajoutcommande();
            commande.Show();
        }
    }
}
