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
    public class ControllerProduit
    {
        SqlConnection cnx = new DalSqlServeur().conexionBd;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        public string s;


//Ajouter Produit
        public void Add(Add_Product Produit)
        {  
            try
            {
                cnx.Open();
                cmd = new SqlCommand("insert into Produit values(@IdProduit,@NomProduit,@Qte_Stock,@Prix,@date,@ImageProduit,@description)", cnx);
                cmd.Parameters.Add(new SqlParameter("@IdProduit", Produit.identifiant));
                cmd.Parameters.Add(new SqlParameter("@NomProduit", Produit.NomProduit));
                cmd.Parameters.Add(new SqlParameter("@Qte_Stock", Produit.QteStock));
                cmd.Parameters.Add(new SqlParameter("@Prix", Produit.Prix));
                cmd.Parameters.Add(new SqlParameter("@date", Produit.Date));
                cmd.Parameters.Add(new SqlParameter("@ImageProduit", Produit.Image));
                cmd.Parameters.Add(new SqlParameter("@description", Produit.Categorie));
                cmd.ExecuteNonQuery();
                MessageBox.Show("bien ajouter", "ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                cnx.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error Produit Déjà Enregistré ");
            }
                
        }//...


//Get Informations
        public DataTable GetAll()
        {
            
            DataTable liste = new DataTable();
            da = new SqlDataAdapter("select * from Produit    ", cnx);
            da.Fill(liste);
            cnx.Close();
            return liste;
        } //...
          

//Rechercher Par Nom
        public DataTable GetBy_Nom(string NomProduit)
        {
            // DataTable liste = new DataTable();
            // try
            // {

            // cnx.Open();
            // SqlCommand cmd = new SqlCommand("select * from Produit where NomProduit like '%" + NomProduit + "%'  ", cnx);
            // cmd.Parameters.AddWithValue("NomProduit", NomProduit);
            // SqlDataAdapter da = new SqlDataAdapter(cmd);
            // da.Fill(liste);
            // cnx.Close();

            // }
            // catch (Exception)
            // {
            //     MessageBox.Show("Produit Non Trouvé ");  
            // }
            //return liste;
            DataTable liste = new DataTable();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from Produit where NomProduit like '%" + NomProduit + "%'  ", cnx);
            cmd.Parameters.AddWithValue("NomProduit", NomProduit);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(liste);
            cnx.Close();
            return liste;


        }//...
    
    
//Modifier Produit
        public void Update_Produit(Add_Product Produit)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("Update Produit  set NomProduit=@NomProduit, Qte_Stock=@Qte_Stock, Prix=@Prix, date=@date, ImageProduit=@ImageProduit,description=@description where IdProduit=@IdProduit ", cnx);
                cmd.Parameters.Add(new SqlParameter("@IdProduit", Produit.identifiant));
                cmd.Parameters.Add(new SqlParameter("@NomProduit", Produit.NomProduit));
                cmd.Parameters.Add(new SqlParameter("@Qte_Stock", Produit.QteStock));
                cmd.Parameters.Add(new SqlParameter("@Prix", Produit.Prix));
                cmd.Parameters.Add(new SqlParameter("@date", Produit.Date));
                cmd.Parameters.Add(new SqlParameter("@ImageProduit", Produit.Image));
                cmd.Parameters.Add(new SqlParameter("@description", Produit.Categorie));
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Informations Modifiées ");
            }
                catch (Exception)
             {
                MessageBox.Show("Error ");
             }  
                
          }//...
             
//Supprimer Produit
        public void delete(string IDProduit)
        {
            cmd = new SqlCommand("delete Produit where IdProduit=@IdProduit ", cnx);
            cnx.Open();
            cmd.Parameters.Add(new SqlParameter("@IdProduit", IDProduit));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }//...

       
     
    }
}
