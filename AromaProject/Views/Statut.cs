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
    public partial class Statut : Form
    {
        public Statut()
        {
            InitializeComponent();
        }
        ControllerProduit control = new ControllerProduit();

        private void Statut_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            gunaDataGridView2.DataSource = control.GetAll();
           

           
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetBy_Nom(txtSearch.Text); 
        }


        //Convert Byte To Image  
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }//...

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            ImprimmerProduit Pr = new ImprimmerProduit();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
           
        }

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

                MessageBox.Show("Selectionez un produit ");
            }
            
          
                
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
             
        }
       

        private void gunaDataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in gunaDataGridView2.Rows)
            {
                if (Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn3"].Value) <= 10)
                {
                    row.Cells["dataGridViewTextBoxColumn3"].Style.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn3"].Value) > 10 && Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn3"].Value) <= 20)
                {
                    row.Cells["dataGridViewTextBoxColumn3"].Style.BackColor = Color.Orange;
                }
                else if (Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn3"].Value) > 20 && Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn3"].Value) <= 40)
                {
                    row.Cells["dataGridViewTextBoxColumn3"].Style.BackColor = Color.Yellow;
                }
                else if (Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn3"].Value) > 40 )
                {
                    row.Cells["dataGridViewTextBoxColumn3"].Style.BackColor = Color.Lime;
                }
            }
        }

        private void BtnQuite_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
