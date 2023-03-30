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
    public partial class Categorie : Form
    {
        public Categorie()
        {
            InitializeComponent();
        }
        Categories categorie;
        ControllerCategorie control = new ControllerCategorie();

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtdescri.Text==""|| txtID.Text=="" )
            {
                MessageBox.Show("Insérez Tout Les Informations");
            }
            else
            {
               categorie = new Categories()
            {
               IdCategorie=txtID.Text,
               DescriptionCat=txtdescri.Text,

            };
            control.Add(categorie);
            gunaDataGridView2.DataSource = control.GetAll();
            txtID.Text = "";
            txtdescri.Text = "";
           

            }
            }
            catch (Exception)
            {

                MessageBox.Show(" Les Informations Sont Incorrectes");

            }
           
          }

        private void Categorie_Load(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
           

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = gunaDataGridView2.CurrentRow.Index;
                txtdescri.Text = gunaDataGridView2.Rows[index].Cells["Description"].Value.ToString();
                txtID.Text = gunaDataGridView2.Rows[index].Cells["NumCategorie"].Value.ToString();
              
            }
            catch (Exception)
            {

                MessageBox.Show("la Categorie Sélectionnée est Invalide");
            }
           
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {

            

                if (txtdescri.Text == "" || txtID.Text == "")
                {
                    MessageBox.Show("Insérez Tout Les Informations");
                }
                else
                {
                    categorie = new Categories()
                    {
                        IdCategorie = txtID.Text,
                        DescriptionCat = txtdescri.Text,
                    };
                    control.Modifier_Catgorie(categorie);
                    gunaDataGridView2.DataSource = control.GetAll();
                    txtID.Text = "";
                    txtdescri.Text = "";


                }
          
            
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                var Exit = MessageBox.Show("Voulez-Vous Supprimer cette Categorie", "Supprimer??", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Exit == DialogResult.Yes)
                {
                    int index = gunaDataGridView2.CurrentRow.Index;
                    string M = gunaDataGridView2.Rows[index].Cells["NumCategorie"].Value.ToString();
                    gunaDataGridView2.Rows.RemoveAt(index);
                    control.delete(M);
                    MessageBox.Show("Categorie Supprimée");
                }
                gunaDataGridView2.DataSource = control.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Sélectionner Une Categorie");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();
        }//... 

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

