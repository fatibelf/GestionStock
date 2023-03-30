using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAromaRazan.Repport;
using GestionAromaRazan.Views;

namespace GestionAromaRazan.Repport
{
    public partial class ImprimmerProduit : Form
    {
        public ImprimmerProduit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintProduis cr = new PrintProduis();
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImprimmerProduit_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentification.Text == "")
                {
                    MessageBox.Show("Insérer l'identifiant de produit");
                }
                else
                {
                    PrintByIdentification cr1 = new PrintByIdentification();
                    cr1.SetParameterValue("Identification", txtIdentification.Text);
                    crystalReportViewer1.ReportSource = cr1;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Produti Non Trouvé");
            }
            
        }
    }
}
