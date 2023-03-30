using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAromaRazan.Views
{
    public partial class Afficher_Image : Form
    {
        PictureBox PIC;
        public Afficher_Image(PictureBox pic)
        {
            InitializeComponent();
            PIC = pic;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Afficher_Image_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = PIC.Image;
        }

        private void BtnQuite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
