using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GestionAromaRazan.Dal
{
    public class DalSqlServeur
    {
        public SqlConnection conexionBd { get; set; }
        public DalSqlServeur()
        {
            conexionBd = new SqlConnection(@"Data Source=.;Initial Catalog=AromaRazane;Integrated Security=True");
        }
    }
}
