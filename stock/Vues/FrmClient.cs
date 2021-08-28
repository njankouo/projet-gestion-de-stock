using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stock.Vues;
using stock.Models;
using stock.DAO;
using System.Data.Odbc;
namespace stock.Vues
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }
        Client cli = new Client();
        public void modelToForm()
        {
            ajoutclient client = new ajoutclient();
            client.Id = cli.id;
                client.Txtnom.Text = cli.nom;
             client.Txttel.Text = cli.tel;
            client.Txtadresse.Text = cli.adresse;
            client.Dtdate.Value =cli.date;
            client.Chketat.Text = cli.etat;
            client.Show();
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ajoutclient add = new ajoutclient();
            add.Show();
        }
        public void loadCustomers()
        {
            List<Client> clients = ClientDAO.findAll();
            dgclient.Rows.Clear();
            foreach (Client client in clients)
            {
                dgclient.Rows.Add(new string[] { client.id.ToString(), client.nom, client.tel, client.adresse,client.date.ToString(),client.etat });
            }
        }
        private void dgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmClient_Load(object sender, System.EventArgs e)
        {
            loadCustomers();
        }

        private void dgclient_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dgclient.CurrentRow.Cells[0].Value.ToString());
            cli = ClientDAO.find(id);
            modelToForm();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

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
