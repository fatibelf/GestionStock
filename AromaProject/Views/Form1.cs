using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAromaRazan.Views;

namespace GestionAromaRazan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string hh, n, q, p, d;
        Image pic;
        private void button1_Click(object sender, EventArgs e)
        {
            AfficherSubMenu(panelProduit);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            costomezDisng();
        }
        public void costomezDisng()
        {
            panelProduit.Visible = false;
            panelClient.Visible = false;
            panelCommande.Visible = false;
            panelAutre.Visible = false;
        }
        public void cacherSubMenu()
        {
            if (panelProduit.Visible==true)
            {
                panelProduit.Visible = false;
            }
            if (panelClient.Visible == true)
            {
                panelClient.Visible = false;
            }
            if (panelCommande.Visible == true)
            {
                panelCommande.Visible = false;
            }
            if (panelAutre.Visible == true)
            {
                panelAutre.Visible = false;
            }


        }
        public void AfficherSubMenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                cacherSubMenu();
                subMenu.Visible = true;
                    
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //code
            //code
            cacherSubMenu();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //code
            //code
            cacherSubMenu();
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            AfficherSubMenu(panelClient);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //code
            //code
            cacherSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //code
            //code
            cacherSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //code
            //code
            cacherSubMenu();
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelchildeForm.Controls.Add(childForm);
            this.panelchildeForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            AfficherSubMenu(panelCommande);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AfficherSubMenu(panelAutre);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //code
            //code
            cacherSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //code
            //code
            cacherSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //code
            //code
            cacherSubMenu();
        }

        private void panelchildeForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
