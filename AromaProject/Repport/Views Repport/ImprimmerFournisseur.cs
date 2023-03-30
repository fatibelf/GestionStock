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
namespace GestionAromaRazan.Repport
{
    public partial class ImprimmerFournisseur : Form
    {
        public ImprimmerFournisseur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListeFornisseurs Pr = new ListeFornisseurs();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintFournisseurs cr = new PrintFournisseurs();
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentification.Text == "")
                {
                    MessageBox.Show("Insérez le CNIE");
                }
                else
                {
                    PrintFournisseurByCnie cr2 = new PrintFournisseurByCnie();
                    cr2.SetParameterValue("CNIE", txtIdentification.Text);
                    crystalReportViewer1.ReportSource = cr2;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Fournisseur Non Trouvé");
            }
           
        }

        private void ImprimmerFournisseur_Load(object sender, EventArgs e)
        {

        }
    }
}
