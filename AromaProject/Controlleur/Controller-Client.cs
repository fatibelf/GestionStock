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
    public class Controller_Client
    {
        SqlConnection cnx = new DalSqlServeur().conexionBd;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

//Ajouter Client
        public void Add(Client Client)      
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand("insert into Clients values(@CNIE,@Nom,@Prenom,@Tele,@Email)", cnx);
                cmd.Parameters.Add(new SqlParameter("@CNIE", Client.Cnie));
                cmd.Parameters.Add(new SqlParameter("@Nom", Client.Nom));
                cmd.Parameters.Add(new SqlParameter("@Prenom", Client.Prenom));
                cmd.Parameters.Add(new SqlParameter("@Tele", Client.Telephone));
                cmd.Parameters.Add(new SqlParameter("@Email", Client.Email));
          
                cmd.ExecuteNonQuery();
                MessageBox.Show("bien ajouter", "ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnx.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error Client Déjà Enregistrée ");
            }

        }//...


//Get Informations
        public DataTable GetAll()
        {
            DataTable liste = new DataTable();
            da = new SqlDataAdapter("select * from Clients    ", cnx);
            da.Fill(liste);
            cnx.Close();
            return liste;
        } //...


//Rechercher Par CNIE
        public DataTable GetBy_CNIE(string NomProduit)
        {
            DataTable liste = new DataTable();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from Clients where CNIE like '%" + NomProduit + "%'  ", cnx);
            cmd.Parameters.AddWithValue("CNIE", NomProduit);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(liste);
            cnx.Close();
            return liste;
        }//...


//Modifier Client
        public void Modifier_Clients(Client Client)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("update Clients set  Nom=@Nom , Prenom=@Prenom , Tele=@Tele , Email=@Email where CNIE=@CNIE ", cnx);
                cmd.Parameters.Add(new SqlParameter("@CNIE", Client.Cnie));
                cmd.Parameters.Add(new SqlParameter("@Nom", Client.Nom));
                cmd.Parameters.Add(new SqlParameter("@Prenom", Client.Prenom));
                cmd.Parameters.Add(new SqlParameter("@Tele", Client.Telephone));
                cmd.Parameters.Add(new SqlParameter("@Email", Client.Email));
                cmd.ExecuteNonQuery();

                cnx.Close();
                MessageBox.Show("Informations Modifiées ");
            }
            catch (Exception)
            {
                MessageBox.Show("Error Client Non Trouvé ");
            }

        }//...


//Supprimer Produit
        public void delete(string CNIE)
        {
            cmd = new SqlCommand("delete Clients where CNIE=@CNIE ", cnx);
            cnx.Open();
            cmd.Parameters.Add(new SqlParameter("@CNIE", CNIE));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }//...













    }
}
