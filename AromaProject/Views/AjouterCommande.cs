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
using GestionAromaRazan.Repport;


namespace GestionAromaRazan.Views
{
    public partial class AjouterCommande : Form
    {
        public AjouterCommande()
        {
            InitializeComponent();
        }
        int qtemodife ;
        int index=0;
        Commande commande;
        ControllerCommande control= new ControllerCommande ();

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
         

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtProduit.Text=="")
                {
                    MessageBox.Show("Indentifiant Produit vide");
                }
                else
                {
                    /////get Qte
                    dataGridView1.DataSource = control.Ge_tQTE(txtProduit.Text);
                    index = dataGridView1.CurrentRow.Index;
                    TXTQTE1.Text = dataGridView1.Rows[index].Cells["Qte"].Value.ToString();
                    /////get prix
                    dataGridView1.DataSource = control.Ge_prix(txtProduit.Text);
                    index = dataGridView1.CurrentRow.Index;
                    txtprix.Text = dataGridView1.Rows[index].Cells["prix"].Value.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Indentifiant Produit est incorrect");

            }

        }

        private void AjouterCommande_Load(object sender, EventArgs e)
        {
           
            gunaDataGridView2.DataSource= control.GetAll();
            dataGridView1.Hide();            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {           
            //try
            //{ 
                  
                   dataGridView1.DataSource = control.Ge_tQTE(txtProduit.Text);
                   index = dataGridView1.CurrentRow.Index;
                //  TXTQTE1.Text = dataGridView1.Rows[index].Cells["Qte"].Value.ToString();
                   int QTE1 = Int32.Parse(TXTQTE1.Text);
                   int QTE2 = Int32.Parse(TXTQTE2.Text);
                if (QTE2>QTE1)
                { 
                  
                    MessageBox.Show("La Quentité est Supérieur de Quantité Disponible");
                }
                else
                {
                 
                 commande = new Commande
            {
               IdCommande= Int32.Parse( txtId.Text),
               CNIE_Client=txtCNIE.Text,
               DateCommande=DateTime.Parse( dateTimePicker2.Text),
               IdentifinatProduit=txtProduit.Text,
               Qte= Int32.Parse(TXTQTE2.Text),
               Prix=float.Parse(txtprix.Text),
               PrixTotal = float.Parse(txtprixtotal.Text)

                 };               
               
               control.Add(commande);
               gunaDataGridView2.DataSource = control.GetAll();
               qtemodife = QTE1 - QTE2;
               control.Update_Quantite(qtemodife, txtProduit.Text);

               txtId.Text = "";
               txtProduit.Text = "";
               TXTQTE2.Text = "";
                TXTQTE2.Text = "";
               txtCNIE.Text = "";
               txtprix.Text = "";
               txtprixtotal.Text = "";

         }
            
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Les Champs Vide ou Les informations Sont Incorrect");
            //}
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtProduit.Text = "";
            TXTQTE2.Text = "";
            txtCNIE.Text = "";
            TXTQTE1.Text = "";
            txtprixtotal.Text = "";
            TXTQTE2.Text = "";
            txtprix.Text = "";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                var Supprimer = MessageBox.Show("Vollez-Vous Supprimer cette Commande", "Supprimer??", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (Supprimer == DialogResult.Yes)
                {
                    
                    //Update Quantite Si La Commande est supprimée
                    int index = gunaDataGridView2.CurrentRow.Index;
                    string Produit = gunaDataGridView2.Rows[index].Cells["IdentifiantProduit"].Value.ToString();
                    dataGridView1.DataSource= control.Ge_tQTE(Produit);
                    int index2 = dataGridView1.CurrentRow.Index;
                    string qteDispo = dataGridView1.Rows[index2].Cells["Qte"].Value.ToString();
                    int QteDispo1 = Int32.Parse(qteDispo);
                    string Qtesupp = gunaDataGridView2.Rows[index].Cells["Quantite"].Value.ToString();
                    int QteSupp1 = Int32.Parse(Qtesupp);
                    int Qtemodife = QteDispo1 + QteSupp1;
                    control.Update_Quantite(Qtemodife, Produit);
                    //...
                    //Supprimer Qte
                    string M = gunaDataGridView2.Rows[index].Cells["NumCommadne"].Value.ToString();
                    gunaDataGridView2.Rows.RemoveAt(index);
                    control.delete(M);
                    MessageBox.Show("Commande Supprimé");
                }
                gunaDataGridView2.DataSource = control.GetAll();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Selectionnez Une Commande ");
            }
               
            
            
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtProduit.Text=="" || txtCNIE.Text==""  || txtProduit.Text=="" ||TXTQTE2.Text=="")
                {
                    MessageBox.Show("virifier les chemps");
                }
                else
                {
                    int index2 = gunaDataGridView2.CurrentRow.Index;
                    string QTEinitial = gunaDataGridView2.Rows[index2].Cells["Quantite"].Value.ToString();
                    int QTEinitial2 = Int32.Parse(QTEinitial);
                    dataGridView1.DataSource = control.Ge_tQTE(txtProduit.Text);
                    index = dataGridView1.CurrentRow.Index;
                    TXTQTE1.Text = dataGridView1.Rows[index].Cells["Qte"].Value.ToString();

                    int QTE1 = Int32.Parse(TXTQTE1.Text);
                    int QTE2 = Int32.Parse(TXTQTE2.Text);
                    if (QTE2 > QTE1)
                    {

                        MessageBox.Show("La Quentité est Supérieur de Quantité Disponible");
                    }
                    else
                    {

                        commande = new Commande
                        {
                            IdCommande = Int32.Parse(txtId.Text),
                            CNIE_Client = txtCNIE.Text,
                            DateCommande = DateTime.Parse(dateTimePicker2.Text),
                            IdentifinatProduit = txtProduit.Text,
                            Qte = Int32.Parse(TXTQTE2.Text),
                            PrixTotal=float.Parse(txtprixtotal.Text)


                        };

                        control.Update_Commande(commande);
                        gunaDataGridView2.DataSource = control.GetAll();
                        qtemodife = (QTE1 + QTEinitial2) - QTE2;
                        control.Update_Quantite(qtemodife, txtProduit.Text);
                        txtId.Text = "";
                        txtProduit.Text = "";
                        TXTQTE2.Text = "";
                        txtCNIE.Text = "";
                    }
                }
               

            }
            catch (Exception)
            {
                MessageBox.Show("Les Champs Vide ou Les informations Sont Incorrect");
            }
        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            int index = gunaDataGridView2.CurrentRow.Index;
            txtProduit.Text = gunaDataGridView2.Rows[index].Cells["IdentifiantProduit"].Value.ToString();
            txtId.Text = gunaDataGridView2.Rows[index].Cells["NumCommadne"].Value.ToString();
            txtCNIE.Text = gunaDataGridView2.Rows[index].Cells["CNIEClient"].Value.ToString();
            TXTQTE2.Text = gunaDataGridView2.Rows[index].Cells["Quantite"].Value.ToString();
            dateTimePicker2.Text = gunaDataGridView2.Rows[index].Cells["DateCommande"].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("la commande Selectionée Invalide");
            }
           
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView2.DataSource = control.GetBy_NumCMD(txtSearch.Text);
            }
            catch (Exception)
            {
                
                MessageBox.Show(" commande Non Trouvé");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintCommande Pr = new PrintCommande();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gunaDataGridView2.DataSource = control.GetAll();
        }//...
        public void calcul()
        {
            
        }
        private void TXTQTE2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void TXTQTE2_MaskChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float a = 0;
            a=float.Parse(txtprix.Text);
            int b = 0;
            b=int.Parse(TXTQTE2.Text);
            float r = 0;
             r= a * b;
            txtprixtotal.Text = r.ToString();

        }

       
    }
}
