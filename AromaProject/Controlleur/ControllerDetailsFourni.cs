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
    public class ControllerDetailsFourni
    {
        SqlConnection cnx = new DalSqlServeur().conexionBd;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

//Ajouter Fornisseur
        public void Add(DetailsFournisseurs Details)
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand("insert into DetailsFournisseurs values( @CNIEFornisseur ,@DateOperation ,@IdentifiantProduit)", cnx);
                cmd.Parameters.Add(new SqlParameter("@CNIEFornisseur", Details.IdFournisseur));
                cmd.Parameters.Add(new SqlParameter("@DateOperation", Details.DateOperation));
                cmd.Parameters.Add(new SqlParameter("@IdentifiantProduit", Details.IdentifiantProudit));
                cmd.ExecuteNonQuery();
                MessageBox.Show("bien ajouter", "ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnx.Close();
                  
            }
            catch (Exception)
            {
                
                MessageBox.Show("Produit ou Fournisseur Non Trouvé");
            }
                
           

        }//...

        //Get Informations
        public DataTable GetAll()
        {
            DataTable liste = new DataTable();
            da = new SqlDataAdapter("select * from DetailsFournisseurs    ", cnx);
            da.Fill(liste);
            cnx.Close();
            return liste;
        } //...

//Supprimer Details Fournisseur
        public void delete(string Id)
        {
            cmd = new SqlCommand("delete DetailsFournisseurs where Id=@Id ", cnx);
            cnx.Open();
            cmd.Parameters.Add(new SqlParameter("@Id", Id));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }//...

//Modifier Details
        public void Modifier_Details(DetailsFournisseurs Details , string ID)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("update DetailsFournisseurs set  CNIEFornisseur=@CNIEFornisseur , DateOperation=@DateOperation , IdentifiantProduit=@IdentifiantProduit where Id=@Id  ", cnx);
                cmd.Parameters.Add(new SqlParameter("@CNIEFornisseur", Details.IdFournisseur));
                cmd.Parameters.Add(new SqlParameter("@DateOperation", Details.DateOperation));
                cmd.Parameters.Add(new SqlParameter("@IdentifiantProduit", Details.IdentifiantProudit));
                cmd.Parameters.Add(new SqlParameter("@Id", ID));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Informations Modifiées ");
                cnx.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error ");
            }


        }//...


//Rechercher Par CNIE
        public DataTable GetBy_CNIE(string CNIE)
        {
            DataTable liste = new DataTable();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from DetailsFournisseurs where CNIEFornisseur like '%" + CNIE + "%'  ", cnx);
            cmd.Parameters.AddWithValue("CNIE", CNIE);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(liste);
            cnx.Close();
            return liste;
        }//...




    }
}
