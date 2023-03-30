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
using GestionAromaRazan.Views;
using System.IO;
using GestionAromaRazan.Repport;

namespace GestionAromaRazan.Views
{
    public partial class ListeProduit : Form
    {
        public ListeProduit()
        {
            InitializeComponent();
        }

//Initialisation
        ControllerProduit control = new ControllerProduit();
        string hh,n,q,p,d;
       

//LOAD
        private void ListeProduit_Load(object sender, EventArgs e)
         {
             pictureBox1.Hide();
             gunaDataGridView2.DataSource = control.GetAll();
         }//...


//Button Fermer
        private void BtnQuite_Click(object sender, EventArgs e)
        {
            this.Close();
        }//...

//Button Ajouter
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            AjouterProduit Pr = new AjouterProduit(hh, n, q, p,pictureBox1.Image,d);
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
            this.Close();
        }//...

//Text Rechercher
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetBy_Nom(txtSearch.Text); 
        }//...


//Button Modifier
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
            int index = gunaDataGridView2.CurrentRow.Index;
            hh = gunaDataGridView2.Rows[index].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            n = gunaDataGridView2.Rows[index].Cells["dataGridViewTextBoxColumn2"].Value.ToString();
            q = gunaDataGridView2.Rows[index].Cells["dataGridViewTextBoxColumn3"].Value.ToString();
            p = gunaDataGridView2.Rows[index].Cells["dataGridViewTextBoxColumn4"].Value.ToString();
            d = gunaDataGridView2.Rows[index].Cells["dataGridViewTextBoxColumn5"].Value.ToString();
            AjouterProduit Pr = new AjouterProduit(hh, n, q, p, pictureBox1.Image,d);
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
            this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Merci de Selectionez un produit Avant Modifier");
            }  
        }

//Convert Byte To Image  
         public Image ConvertByteArrayToImage(byte[] data)
         {
             using (MemoryStream ms = new MemoryStream(data))
           {
             return Image.FromStream(ms);
           }
                
          }//...
            
 //Afficher Image Apartir De DataGrid
         private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             try
             {
                 
                 DataTable dt = gunaDataGridView2.DataSource as DataTable;
                 if (dt != null)
                 {
                   DataRow row = dt.Rows[e.RowIndex];
                   pictureBox1.Image = ConvertByteArrayToImage((byte[])row["ImageProduit"]);
                   
                 }
               }
             catch (Exception)
             {
                 MessageBox.Show("Image NoN trouvée");
             }
           }//...
         

//Button Supprimer
         private void BtnSupprimer_Click(object sender, EventArgs e)
         {
            try
             {
                 var Exit = MessageBox.Show("Vollez-Vous Supprimer ce Produit", "Supprimer??", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                 if (Exit == DialogResult.Yes)
                 {
                     int index = gunaDataGridView2.CurrentRow.Index;
                     string M = gunaDataGridView2.Rows[index].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                     gunaDataGridView2.Rows.RemoveAt(index);
                     control.delete(M);
                     MessageBox.Show("Produit Supprimé");
                 }
                 gunaDataGridView2.DataSource = control.GetAll();
             }
             catch (Exception)
             {
                 MessageBox.Show("Selectionner Un Produit");
             }
            }

         private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }

         private void BtnImprimer_Click(object sender, EventArgs e)
         {
             ImprimmerProduit Pr = new ImprimmerProduit();
             foreach (Form fc in this.MdiChildren)
             {
                 fc.Close();
             }
             Pr.Show();
          
         }

         private void button1_Click(object sender, EventArgs e)
         {
             try
             {
                 if (pictureBox1.Image == null)
                 {
                     MessageBox.Show(" Selectionez un produit ");

                 }
                 else
                 {
             Afficher_Image Pr = new Afficher_Image(pictureBox1);
             foreach (Form fc in this.MdiChildren)
             {
                 fc.Close();
             }
             Pr.Show();
                 }
             
             }
             catch (Exception)
             {

                 MessageBox.Show(" Selectionez un produit ");
             }
             
             

         }//... 
         

       
    }
}
