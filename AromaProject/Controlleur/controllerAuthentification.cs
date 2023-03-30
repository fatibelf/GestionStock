using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestionAromaRazan.Dal;



namespace GestionAromaRazan.Controlleur
{
    public class controllerAuthentification
    {
        SqlConnection cnx = new DalSqlServeur().conexionBd;
        SqlCommand cmd;
        SqlDataReader dr;
        public string Autentifier(string pLogin, string pPasse)
        {
            string role = null;
            cnx.Open();
            cmd = new SqlCommand("select * from Users where login=@login and passe=@passe", cnx);
            cmd.Parameters.Add(new SqlParameter("@login", pLogin));
            cmd.Parameters.Add(new SqlParameter("@passe", pPasse));
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                role = dr.GetValue(4).ToString();
            }
            cnx.Close();
            return role;
        }
    }
}
