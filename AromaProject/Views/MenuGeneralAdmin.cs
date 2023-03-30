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
    public partial class MenuGeneralAdmin : Form
    {
        public MenuGeneralAdmin()
        {
            InitializeComponent();

        }
        string hh, n, q, p,C, N, P, T, E,d;
        Image pic;
       

        private void MenuGeneralAdmin_Load(object sender, EventArgs e)
        {

            Statut Pr = new Statut();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;
            Pr.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AjouterProduit Pr = new AjouterProduit(hh, n, q, p,pic,d);
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;
            Pr.Show();
            //Pr.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        
        }

        private void listeProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeProduit Pr = new ListeProduit();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;

            //Pr.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            Pr.Show();
        }

        private void cmmandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ajouter_Client Pr = new Ajouter_Client(C, N, P, T, E);
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;
            Pr.Show();
        }

        private void listeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListeClients Pr = new ListeClients();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;
            Pr.Show();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Fornisseur Pr = new Fornisseur(hh, n, q, p, C, N);
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;
            Pr.Show();
        }

        private void listeFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListeFornisseurs Pr = new ListeFornisseurs();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;
            Pr.Show();
        }

        private void ajouterCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterCommande Pr = new AjouterCommande();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;
            Pr.Show();
        }

        

        private void ajouterCategorieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Categorie Pr = new Categorie();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;
            Pr.Show();
        }

        private void detailsFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsFournisseur Pr = new DetailsFournisseur();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;
            Pr.Show();
        }

        private void statutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statut Pr = new Statut();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.MdiParent = this;
            Pr.Show();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
