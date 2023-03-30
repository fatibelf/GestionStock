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
using GestionAromaRazan.Views;
using GestionAromaRazan.Dal;
namespace GestionAromaRazan.Views
{
    public partial class Ajouter_Client : Form
    {
//Inisialisation
        string c, n, p, t, EM;
        public Ajouter_Client(string C, string N, string P ,string T, string  E)
        {
            InitializeComponent();
            c = C;
            n = N;
            p = P;
            t = T;
            EM = E;
        }
        Controller_Client control = new Controller_Client();
        Client client;
//...     
        
        
//LOAD
        private void Ajouter_Client_Load(object sender, EventArgs e)
        {
            txtCNIE.Text = c;
            txtEMAIL.Text = EM;
            txtNom.Text = n;
            txtPRENOM.Text = p;
            txtTELEPHONE.Text = t;
            gunaDataGridView2.DataSource = control.GetAll();

        }//...


//BUTTON Ajouter
        private void button_add_Click(object sender, EventArgs e)
        {
            if (txtCNIE.Text==""|| txtEMAIL.Text=="" || txtNom.Text=="" || txtPRENOM.Text==""|| txtTELEPHONE.Text=="")
            {
                MessageBox.Show("Insérez Tout Les Informations");
            }
            else
            {
               client = new Client()
            {
               Cnie=txtCNIE.Text,
               Nom=txtNom.Text,
               Prenom=txtPRENOM.Text,
               Email=txtEMAIL.Text,
               Telephone=txtTELEPHONE.Text,
            };
            control.Add(client);
            gunaDataGridView2.DataSource = control.GetAll();
            txtCNIE.Text = "";
            txtEMAIL.Text = "";
            txtNom.Text = "";
            txtPRENOM.Text = "";
            txtTELEPHONE.Text = "";

            }
          }//... 

        private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                gunaDataGridView2.CurrentRow.Selected = true;
                int index = gunaDataGridView2.CurrentRow.Index;
                txtCNIE.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNom.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPRENOM.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTELEPHONE.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEMAIL.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("la Categorie Sélectionnée est Invalide");
            }
        }


        //BUTTON Fermer
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }//...


//BUTTON Actualiser
        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();
        }//...


//BUTTON Vider
        private void button_clear_Click(object sender, EventArgs e)
        {
            txtCNIE.Text     ="";
            txtEMAIL.Text    ="";
            txtNom.Text      ="";
            txtPRENOM.Text   ="";
            txtTELEPHONE.Text="";
        }//...


//BUTTON Modifier
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (txtCNIE.Text == "" || txtEMAIL.Text == "" || txtNom.Text == "" || txtPRENOM.Text == "" || txtTELEPHONE.Text == "")
            {
                MessageBox.Show("Insérez Tout Les Informations");
            }
            else
            {
                gunaDataGridView2.DataSource = control.GetAll();
                client = new Client()
                {
                    Cnie = txtCNIE.Text,
                    Nom = txtNom.Text,
                    Prenom = txtPRENOM.Text,
                    Email = txtEMAIL.Text,
                    Telephone = txtTELEPHONE.Text,
                };

                control.Modifier_Clients(client);
                gunaDataGridView2.DataSource = control.GetAll();
               
            }
        }//...

        


    }
}
