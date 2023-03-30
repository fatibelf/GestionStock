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
    public partial class PrintCommande : Form
    {
        public PrintCommande()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjouterCommande Pr = new AjouterCommande();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintCommand cr = new PrintCommand();
            crystalReportViewer1.ReportSource = cr;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentification.Text == "")
                {
                    MessageBox.Show("Inserez l'identification de produit");
                }
                else
                {
                    printComandByNum cr1 = new printComandByNum();
                    cr1.SetParameterValue("Numcmd", txtIdentification.Text);
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
