using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAromaRazan.Controlleur;
using GestionAromaRazan.Repport;

namespace GestionAromaRazan.Views
{
    public partial class ListeClients : Form
    {
        public ListeClients()
        {
            InitializeComponent();
        }
//Initialisation
        Controller_Client control = new Controller_Client();
        string C, N, P, T, E;


//LOAD 
        private void ListeClients_Load(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();
        }//...


//BUTTON Ajouter
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter_Client Pr = new Ajouter_Client(C, N, P, T, E);
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
            this.Close();
        }//...


//BUTTON Fermer
        private void BtnQuite_Click(object sender, EventArgs e)
        {
            this.Close();
        }//...


//TextBox Rechercher
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetBy_CNIE(txtSearch.Text);
        }//...


//BUTTON Modifier
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gunaDataGridView2.CurrentRow.Index;
                C = gunaDataGridView2.Rows[index].Cells["CNIE"].Value.ToString();
                N = gunaDataGridView2.Rows[index].Cells["Nom"].Value.ToString();
                P = gunaDataGridView2.Rows[index].Cells["Prenom"].Value.ToString();
                T = gunaDataGridView2.Rows[index].Cells["Telephone"].Value.ToString();
                E = gunaDataGridView2.Rows[index].Cells["Email"].Value.ToString();
                Ajouter_Client Pr = new Ajouter_Client(C,N,P,T,E);
                foreach (Form fc in this.MdiChildren)
                {
                    fc.Close();
                }
                Pr.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Merci de Sélectionner un Client  ");
            }  
        }//...


//BUTTON Supprimer
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                var Exit = MessageBox.Show("Voulez-Vous Supprimer ce Client", "Supprimer??", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Exit == DialogResult.Yes)
                {
                    int index = gunaDataGridView2.CurrentRow.Index;
                    string M = gunaDataGridView2.Rows[index].Cells["CNIE"].Value.ToString();
                    gunaDataGridView2.Rows.RemoveAt(index);
                    control.delete(M);
                    MessageBox.Show("Client Supprimé");
                }
                gunaDataGridView2.DataSource = control.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Sélectionner Un Client");
            }
        }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            PrintListClient Pr = new PrintListClient();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }//...






    }
}
