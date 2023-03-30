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
using GestionAromaRazan.Modul;

namespace GestionAromaRazan.Views
{
    public partial class DetailsFournisseur : Form
    {
        public DetailsFournisseur()
        {
            InitializeComponent();
        }
        ControllerDetailsFourni control = new ControllerDetailsFourni();
        DetailsFournisseurs details;
        string IDcelll;
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            

            if (txtCNIE.Text == "" || txtProduit.Text == "")
            {
                MessageBox.Show("Inserez Tout Les Informations");
            }
            else
            {
                details = new DetailsFournisseurs()
                {
                 
                     IdFournisseur = txtCNIE.Text,
                    DateOperation = DateTime.Parse(dateTimePicker2.Text),
                    IdentifiantProudit=txtProduit.Text,
                };
                control.Add(details);
                gunaDataGridView2.DataSource = control.GetAll();
                txtCNIE.Text = "";
                txtProduit.Text = "";

            }
        }

        private void DetailsFournisseur_Load(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                var Exit = MessageBox.Show("Voulez-Vous Supprimer Les Details", "Supprimer??", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Exit == DialogResult.Yes)
                {
                    int index = gunaDataGridView2.CurrentRow.Index;
                    string M = gunaDataGridView2.Rows[index].Cells["Numero"].Value.ToString();
                    gunaDataGridView2.Rows.RemoveAt(index);
                    control.delete(M);
                    MessageBox.Show("Details Supprimées");
                }
                gunaDataGridView2.DataSource = control.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Selectionner Details");
            }
        }

        private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = gunaDataGridView2.CurrentRow.Index;
                txtProduit.Text = gunaDataGridView2.Rows[index].Cells["PRODUIT"].Value.ToString();
                txtCNIE.Text = gunaDataGridView2.Rows[index].Cells["CNIE"].Value.ToString() ;
                dateTimePicker2.Text = gunaDataGridView2.Rows[index].Cells["DateOperation"].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("la commande Selectionée Invalide");
            }
           
            
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (txtCNIE.Text == "" || txtProduit.Text == "")
            {
                MessageBox.Show("Inserez Tout Les Informations");
            }
            else
            {
                int index = gunaDataGridView2.CurrentRow.Index;
                string M = gunaDataGridView2.Rows[index].Cells["Numero"].Value.ToString();

                details = new DetailsFournisseurs()
                {

                    IdFournisseur = txtCNIE.Text,
                    DateOperation = DateTime.Parse(dateTimePicker2.Text),
                    IdentifiantProudit = txtProduit.Text,
                };
                control.Modifier_Details(details,M);
                gunaDataGridView2.DataSource = control.GetAll();
                txtCNIE.Text = "";
                txtProduit.Text = "";

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetBy_CNIE(txtSearch.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();
        }
    }
}
