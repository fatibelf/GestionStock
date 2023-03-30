using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAromaRazan.Modul
{
     public class Client
    {

        public string Cnie { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public Client() { }
        public Client(string CNIE, string NOM, string PRENOM, string TELEPHONE, string EMAIL)
        {
            Cnie = CNIE;
            Nom = NOM;
            Prenom = PRENOM;
            Telephone = TELEPHONE;
            Email = EMAIL;
        
        
        }





    }
}
