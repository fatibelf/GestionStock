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
using System.IO;
using GestionAromaRazan.Views;
using GestionAromaRazan.Dal;
using System.Data.SqlClient;


namespace GestionAromaRazan.Views
{
    public partial class AjouterProduit : Form
    {
//Importer les deonnees Poour Modifier
        string H,n,q,p;
        Image pic;
        string D;
        public AjouterProduit(string h, string N, string Q, string P, Image a, string d)
        {
            InitializeComponent();
            H = h;
            n = N;
            q = Q;
            p = P;
            pic=a;
            D = d;
        }
        ControllerProduit control = new ControllerProduit();
        Add_Product Produit = new Add_Product();
        SqlConnection cnx = new DalSqlServeur().conexionBd;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da; 
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//LOAD
        private void AjouterProduit_Load(object sender, EventArgs e)
        {
//Remplir DataGridView
            gunaDataGridView2.DataSource = control.GetAll();
            this.Width=876;
            this.Height = 517;

//Donees Pour Modifier
            dateTimePicker2.Text =  D;
            pictureBox_student.Image = pic;
            txtId.Text = H;
            txtNom.Text = n;
            txtPrix.Text =p;
            txtQuantite.Text = q;
          
//Remplir ComboBox
            cnx.Open();
            control.s = "select distinct descriptionCAt from categorie ";
            cmd = new SqlCommand(control.s, cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                gunaComboBox1.Items.Add(dr[0]);
            }
            dr.Close();
               
        }//...

//Button Ajouter
        private void button_add_Click_1(object sender, EventArgs e)
        {
            if (pictureBox_student.Image == null)
            {
                MessageBox.Show("SVP ajouter une image");
            }
            else
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    Produit = new Add_Product
                    {
                        identifiant = txtId.Text,
                        NomProduit = txtNom.Text,
                        Prix = txtPrix.Text,
                        Categorie = gunaComboBox1.Text,
                        QteStock = Convert.ToInt32(txtQuantite.Text),
                        Date = DateTime.Parse(dateTimePicker2.Text),
                        Image = byteImage,
                    };
                    control.Add(Produit);
                    gunaDataGridView2.DataSource = control.GetAll();
                    txtId.Text = "";
                    txtNom.Text = "";
                    txtPrix.Text = "";
                    txtQuantite.Text = "";
                    gunaComboBox1.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Insérez tout Les informations ");
                }
            }
            
        }//...
        

//Button Importer Image
        private void button_upload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Ajouter image (*.JPG; *.PNG; *.GIF; *.BMP) |*.JPG; *.PNG; *.GIF; *.BMP";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_student.Image = Image.FromFile(opf.FileName);
            }
        }//...

//Button Vider
        private void button_clear_Click_1(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtPrix.Text = "";
            txtQuantite.Text = "";
            dateTimePicker2.Value = DateTime.Now;
            gunaComboBox1.Items.Clear();
            pictureBox_student.Image = null;

        }//...

        private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                gunaDataGridView2.CurrentRow.Selected = true;
                int index = gunaDataGridView2.CurrentRow.Index;
                txtId.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNom.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantite.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrix.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePicker2.Text = gunaDataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                gunaComboBox1.Text= gunaDataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])gunaDataGridView2.Rows[e.RowIndex].Cells[5].Value);
                pictureBox_student.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

                MessageBox.Show("la Categorie Sélectionnée est Invalide");
            }
        }

        //Button Enregistrer Apres Modifier
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (pictureBox_student.Image == null)
            {
                MessageBox.Show("SVP ajouter une image");
            }
            else
            {
                try
                {
                    gunaDataGridView2.DataSource = control.GetAll();
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    Produit = new Add_Product
                    {
                        identifiant = txtId.Text,
                        NomProduit = txtNom.Text,
                        Prix = txtPrix.Text,
                        Categorie = gunaComboBox1.Text,
                        QteStock = Convert.ToInt32(txtQuantite.Text),
                        Date = DateTime.Parse(dateTimePicker2.Text),
                        Image = byteImage,
                    };
                    control.Update_Produit(Produit);
                }
                catch (Exception)
                {

                    MessageBox.Show("Sélectionnez Un Produit De Liste Produit ");
                }
            }
           
        }//...

    
//Button Actualiser
        private void button4_Click(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();

        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//...


    }
}
