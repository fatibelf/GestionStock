using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestionAromaRazan.Dal;
using GestionAromaRazan.Modul;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace GestionAromaRazan.Controlleur
{
   public class ControllerCategorie
    {
        SqlConnection cnx = new DalSqlServeur().conexionBd;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

//Ajouter categorie
        public void Add(Categories  Categorie)
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand("insert into categorie values(@IdCategorie,@descriptionCAt)", cnx);
                cmd.Parameters.Add(new SqlParameter("@IdCategorie", Categorie.IdCategorie));
                cmd.Parameters.Add(new SqlParameter("@descriptionCAt", Categorie.DescriptionCat));
                cmd.ExecuteNonQuery();
                MessageBox.Show("bien ajouter", "ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnx.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error categorie Déja Enregistrée ");
            }

        }//...

//Get Informations
        public DataTable GetAll()
        {
            DataTable liste = new DataTable();
            da = new SqlDataAdapter("select * from categorie    ", cnx);
            da.Fill(liste);
            cnx.Close();
            return liste;
        } //...

//Modifier categorie
        public void Modifier_Catgorie(Categories Categorie)
        {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("update  categorie set   descriptionCAt=@descriptionCAt  where IdCategorie=@IdCategorie ", cnx);
                cmd.Parameters.Add(new SqlParameter("@IdCategorie", Categorie.IdCategorie));
                cmd.Parameters.Add(new SqlParameter("@descriptionCAt", Categorie.DescriptionCat));
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Informations Modifiées ");
           
            
        }//...

//Supprimer categorie
        public void delete(string IdCategorie)
        {
            cmd = new SqlCommand("delete categorie where IdCategorie=@IdCategorie ", cnx);
            cnx.Open();
            cmd.Parameters.Add(new SqlParameter("@IdCategorie", IdCategorie));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }//...



    }
}
