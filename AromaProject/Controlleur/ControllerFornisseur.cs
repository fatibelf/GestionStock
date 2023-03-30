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
   public class ControllerFornisseur
    {
        SqlConnection cnx = new DalSqlServeur().conexionBd;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;



//Ajouter Fornisseur
        public void Add(Fornisseurs Fornisseur)
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand("insert into Fournisseur  values(@IdFournisseur,@Nom,@Prenom,@Adresse,@Telephone,@Numero_compte)", cnx);
                cmd.Parameters.Add(new SqlParameter("@IdFournisseur", Fornisseur.Cnie));
                cmd.Parameters.Add(new SqlParameter("@Nom", Fornisseur.Nom));
                cmd.Parameters.Add(new SqlParameter("@Prenom", Fornisseur.Prenom));
                cmd.Parameters.Add(new SqlParameter("@Adresse", Fornisseur.Adresse));
                cmd.Parameters.Add(new SqlParameter("@Telephone", Fornisseur.Telephone));
                cmd.Parameters.Add(new SqlParameter("@Numero_compte", Fornisseur.NumeroCompte));
                cmd.ExecuteNonQuery();
                MessageBox.Show("bien ajouter", "ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnx.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error Fournisseur Déja Enregistrer ");
            }

        }//...


//Get Informations
        public DataTable GetAll()
        {
            DataTable liste = new DataTable();
            da = new SqlDataAdapter("select * from Fournisseur    ", cnx);
            da.Fill(liste);
            cnx.Close();
            return liste;
        } //...

//Rechercher Par CNIE
        public DataTable GetBy_CNIE(string CNIE)
        {
            DataTable liste = new DataTable();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from Fournisseur where IdFournisseur like '%" + CNIE + "%'  ", cnx);
            cmd.Parameters.AddWithValue("CNIE", CNIE);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(liste);
            cnx.Close();
            return liste;
        }//...

//Supprimer Fournisseur
        public void delete(string CNIE)
        {
            cmd = new SqlCommand("delete Fournisseur where IdFournisseur=@IdFournisseur ", cnx);
            cnx.Open();
            cmd.Parameters.Add(new SqlParameter("@IdFournisseur", CNIE));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }//...


//Modifier Fournisseur
        public void Modifier_Fornisseur(Fornisseurs Fornisseur)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("update Fournisseur set  Nom=@Nom , Prenom=@Prenom , Adresse=@Adresse,Telephone=@Telephone, Numero_compte=@Numero_compte where IdFournisseur=@IdFournisseur ", cnx);
                cmd.Parameters.Add(new SqlParameter("@IdFournisseur", Fornisseur.Cnie));
                cmd.Parameters.Add(new SqlParameter("@Nom", Fornisseur.Nom));
                cmd.Parameters.Add(new SqlParameter("@Prenom", Fornisseur.Prenom));
                cmd.Parameters.Add(new SqlParameter("@Adresse", Fornisseur.Adresse));
                cmd.Parameters.Add(new SqlParameter("@Telephone", Fornisseur.Telephone));
                cmd.Parameters.Add(new SqlParameter("@Numero_compte", Fornisseur.NumeroCompte));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Informations Modifiées ");
                cnx.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error Fournisseur Non Trouvé ");
            }
                

        }//...












    }
}
