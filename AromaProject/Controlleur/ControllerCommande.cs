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
  public  class ControllerCommande
    {

        SqlConnection cnx = new DalSqlServeur().conexionBd;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;


//Ajouter Commande 
        public void Add(Commande Commande)

        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand("insert into CommandeClient values(@IdCommande,@IdentifiantProduit,@CNIE_Client,@Qte,@DateCommande,@Prix,@PrixTotal)", cnx);
                cmd.Parameters.Add(new SqlParameter("@IdCommande", Commande.IdCommande));
                cmd.Parameters.Add(new SqlParameter("@IdentifiantProduit", Commande.IdentifinatProduit));
                cmd.Parameters.Add(new SqlParameter("@CNIE_Client", Commande.CNIE_Client));
                cmd.Parameters.Add(new SqlParameter("@Qte", Commande.Qte));
                cmd.Parameters.Add(new SqlParameter("@DateCommande", Commande.DateCommande));
                cmd.Parameters.Add(new SqlParameter("@Prix", Commande.Prix));
                cmd.Parameters.Add(new SqlParameter("@PrixTotal", Commande.PrixTotal));

                cmd.ExecuteNonQuery();
                MessageBox.Show("bien ajouter", "ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnx.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Client ou Produit Non Trouvé ");
            }

        }//...

//Get Informations
        public DataTable GetAll()
        {
            DataTable liste = new DataTable();
            da = new SqlDataAdapter("select * from CommandeClient    ", cnx);
            da.Fill(liste);
            cnx.Close();
            return liste;
        } //...


        //Verifier Qte de Produit 
        public DataTable Ge_tQTE(string IdProduit)
        {
            DataTable liste = new DataTable();
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select Qte_Stock from Produit where IdProduit=@IdProduit ", cnx);
                cmd.Parameters.AddWithValue("@IdProduit", IdProduit);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(liste);
                cnx.Close();  
            }
          
            catch (Exception)
            {

                MessageBox.Show("Verifier L'identifiant De Produit");
            }  
            return liste;
           
        }//...

//Modifier Quantité
        public void Update_Quantite(int QteStock2 , string IDPRODUIT)
        {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("Update Produit set Qte_Stock=@Qte_Stock where IdProduit=@IdProduit ", cnx);
                cmd.Parameters.Add(new SqlParameter("@Qte_Stock", QteStock2));
                cmd.Parameters.Add(new SqlParameter("@IdProduit", IDPRODUIT));


                cmd.ExecuteNonQuery();
                cnx.Close();
        }//...

//Supprimer Commande
        public void delete(string IdCommande)
        {   
            cmd = new SqlCommand("delete CommandeClient where IdCommande=@IdCommande ", cnx);
            cnx.Open();
            cmd.Parameters.Add(new SqlParameter("@IdCommande", IdCommande));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }//...

//Modifier Commande
        public void Update_Commande(Commande Commande)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("Update CommandeClient  set IdentifiantProduit=@IdentifiantProduit, CNIE_Client=@CNIE_Client, Qte=@Qte, DateCommande=@DateCommande where IdCommande=@IdCommande ", cnx);
                cmd.Parameters.Add(new SqlParameter("@IdCommande", Commande.IdCommande));
                cmd.Parameters.Add(new SqlParameter("@IdentifiantProduit", Commande.IdentifinatProduit));
                cmd.Parameters.Add(new SqlParameter("@CNIE_Client", Commande.CNIE_Client));
                cmd.Parameters.Add(new SqlParameter("@Qte", Commande.Qte));
                cmd.Parameters.Add(new SqlParameter("@DateCommande", Commande.DateCommande));

                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Informations Modifiées ");
            }
            catch (Exception)
            {
                MessageBox.Show("Les informations Sont Incorrectes ");
            }

        }//...

//Rechercher Par num commande
        public DataTable GetBy_NumCMD(string NumCommande)
        {
            DataTable liste = new DataTable();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from CommandeClient where IdCommande like '%" + NumCommande + "%'  ", cnx);
            cmd.Parameters.AddWithValue("NomProduit", NumCommande);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(liste);
            cnx.Close();
            return liste;
        }//...

        ///
        public DataTable Ge_prix(string IdProduit)
        {
            DataTable liste = new DataTable();
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select Prix from Produit where IdProduit=@IdProduit ", cnx);
                cmd.Parameters.AddWithValue("@IdProduit", IdProduit);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(liste);
                cnx.Close();
            }

            catch (Exception)
            {

                MessageBox.Show("Verifier L'identifiant De Produit");
            }
            return liste;

        }//...
    }
}
