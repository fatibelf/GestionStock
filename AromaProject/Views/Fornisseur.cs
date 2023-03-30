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
    public partial class Fornisseur : Form
    {
//Importer information de Liste Foournisseur
        string c, n, p, a, t, ncompte;
        public Fornisseur(string C, string N, string P, string A, string T, string NCOMPTE)
        {
            InitializeComponent();
            c = C;
            n = N;
            p = P;
            a = A;
            t = T;
            ncompte = NCOMPTE;
        }//...
        Fornisseurs fornisseur;
        ControllerFornisseur control = new ControllerFornisseur(); 
        
        
//LOAD
        private void Fornisseur_Load(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();
            //Remplir Les TextBox Pour Modifier
            txtCNIE.Text = c;
            txtAdresse.Text = a;
            txtNom.Text = n;
            txtPRENOM.Text = p;
            txtTELEPHONE.Text = t;
            txtNumCoMPTE.Text = ncompte;

        }

        private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                gunaDataGridView2.CurrentRow.Selected = true;
                int index = gunaDataGridView2.CurrentRow.Index;
                txtCNIE.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNom.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPRENOM.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAdresse.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTELEPHONE.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNumCoMPTE.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("la Categorie Sélectionnée est Invalide");
            }
        }

        //bUTTON Ajouter
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCNIE.Text == "" || txtAdresse.Text == "" || txtNom.Text == "" || txtPRENOM.Text == "" || txtTELEPHONE.Text == "" || txtNumCoMPTE.Text== "")
                {
                    MessageBox.Show("Inserez Tout Les Informations");
                }
                else
                {
                    fornisseur = new Fornisseurs()
                {
                    Cnie = txtCNIE.Text,
                    Nom = txtNom.Text,
                    Prenom = txtPRENOM.Text,
                    Adresse = txtAdresse.Text,
                    Telephone = txtTELEPHONE.Text,
                    NumeroCompte = txtNumCoMPTE.Text,
                };
                   control.Add(fornisseur);
                   gunaDataGridView2.DataSource = control.GetAll();
                   txtCNIE.Text=      "";
                   txtAdresse.Text = "";
                   txtNom.Text=       "";
                   txtPRENOM.Text=    "";
                   txtTELEPHONE.Text= "";
                   txtNumCoMPTE.Text= "";

                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Insérez Tout Les Informations");
            }
          }//... 
                
//BUTTON Vider
        private void button_clear_Click(object sender, EventArgs e)
        {
            txtCNIE.Text = "";
            txtAdresse.Text = "";
            txtNom.Text = "";
            txtPRENOM.Text = "";
            txtTELEPHONE.Text = "";
            txtNumCoMPTE.Text = "";
        }//...
        



//BUTTON Fermer
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }//...

       
//BUTTON Modifier
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtCNIE.Text == ""||txtAdresse.Text == ""|| txtNom.Text =="" ||txtTELEPHONE.Text ==""||txtPRENOM.Text ==""||txtNumCoMPTE.Text =="")
                {
                    MessageBox.Show("Insérez Tout Les Informations");
                }
                else
                {
                    fornisseur = new Fornisseurs()
                {
                    Cnie = txtCNIE.Text,
                    Nom = txtNom.Text,
                    Prenom = txtPRENOM.Text,
                    Adresse = txtAdresse.Text,
                    Telephone = txtTELEPHONE.Text,
                    NumeroCompte = txtNumCoMPTE.Text,
                };
                    control.Modifier_Fornisseur(fornisseur);
                    gunaDataGridView2.DataSource = control.GetAll();
                    txtCNIE.Text = "";
                    txtAdresse.Text = "";
                    txtNom.Text = "";
                    txtPRENOM.Text = "";
                    txtTELEPHONE.Text = "";
                    txtNumCoMPTE.Text = "";
                }

              }  
                 catch (Exception)
            {
                MessageBox.Show("Error");
            }
          }

//BUTTON Actualiser
        private void button4_Click(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();

        }//...
           
        
    }
}
