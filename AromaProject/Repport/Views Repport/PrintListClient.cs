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
    public partial class PrintListClient : Form
    {
        public PrintListClient()
        {
            InitializeComponent();
        }

        private void PrintListClient_Load(object sender, EventArgs e)
        {
            //PrintListClient cr = new CrystalReport1();
            //crystalReportViewer1.ReportSource = cr;
            //crystalReportViewer1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ListeClients Pr = new ListeClients();
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            Pr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintClient cr = new PrintClient();
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentification.Text == "")
                {
                    MessageBox.Show("Inserez le CNIE");
                }
                else
                {
                    PrintByCNIE cr2 = new PrintByCNIE();
                    cr2.SetParameterValue("cne", txtIdentification.Text);
                    crystalReportViewer1.ReportSource = cr2;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Client Non Trouvé");
            }

        }
    }
}
