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
    public partial class ListeFornisseurs : Form
    {
        public ListeFornisseurs()
        {
            InitializeComponent();
        }
//Initialisation
        string c, n, p, a, t, ncompte;
        ControllerFornisseur control = new ControllerFornisseur();


//BUTTON Ajouter
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Fornisseur Pr = new Fornisseur(c, n, p, a, t, ncompte);
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
            this.Close();
        }//...


//TEXTBOX Rechercher
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetBy_CNIE(txtSearch.Text);
        }//...


//BUTTON Fermer
        private void BtnQuite_Click(object sender, EventArgs e)
        {
            this.Close();
        }//...


//BUTTON Supprimer
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {

            try
            {
                var Exit = MessageBox.Show("Voulez-Vous Supprimer ce Fournisseur", "Supprimer??", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Exit == DialogResult.Yes)
                {
                    int index = gunaDataGridView2.CurrentRow.Index;
                    string M = gunaDataGridView2.Rows[index].Cells["CNIE"].Value.ToString();
                    gunaDataGridView2.Rows.RemoveAt(index);
                    control.delete(M);
                    MessageBox.Show("Fournisseur Supprimé");
                }
                gunaDataGridView2.DataSource = control.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Selectionner Un Fournisseur");
            }
        }//...

       
//BUTTON Modifier
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gunaDataGridView2.CurrentRow.Index;
                c = gunaDataGridView2.Rows[index].Cells["CNIE"].Value.ToString();
                n = gunaDataGridView2.Rows[index].Cells["Nom"].Value.ToString();
                p = gunaDataGridView2.Rows[index].Cells["Prenom"].Value.ToString();
                t = gunaDataGridView2.Rows[index].Cells["Telephone"].Value.ToString();
                a = gunaDataGridView2.Rows[index].Cells["Adresse"].Value.ToString();
                ncompte = gunaDataGridView2.Rows[index].Cells["NumeroCompte"].Value.ToString();

                Fornisseur Pr = new Fornisseur(c, n, p, a, t, ncompte);
                foreach (Form fc in this.MdiChildren)
                {
                    fc.Close();
                }
                Pr.Show();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Selectionner Un Fournisseur");
            }
               
          }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            ImprimmerFournisseur Pr = new ImprimmerFournisseur();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ListeFornisseurs_Load(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();

        }//...
           
        
    }
}
