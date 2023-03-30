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

namespace GestionAromaRazan.Views
{
    public partial class Autontification : Form
    {
        public Autontification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Autontification_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string aRole = null;
            try
            {
                aRole = new controllerAuthentification().Autentifier(txtLogin.Text, txtPassword.Text);
                if (aRole.Equals("Admin"))
                {
                    MenuGeneralAdmin n = new MenuGeneralAdmin();
                    n.ShowDialog();
                    this.Close();
                }
                //else if (aRole.Equals("user"))
                //{
                //    new prof().Show();
                //}

            }
            catch (Exception)
            {

                MessageBox.Show("Utilisateur non authentifiée");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0' )
            {
                button1.BringToFront();
                txtPassword.PasswordChar = '*';
            }
            else
            {
                button1.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
                {
                button1.BringToFront();
                txtPassword.PasswordChar = '\0';
                }
            else
            {

                button1.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
