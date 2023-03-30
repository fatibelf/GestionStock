using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAromaRazan.Modul
{
   public class Fornisseurs
    {

       
        public string Cnie { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string   NumeroCompte { get; set; }
            

        public Fornisseurs() { }
        public Fornisseurs(string CNIE, string NOM, string PRENOM, string TELEPHONE, string ADRESSE, string NUMEROCOMPTE)
        {
            Cnie = CNIE;
            Nom = NOM;
            Prenom = PRENOM;
            Telephone = TELEPHONE;
            Adresse = ADRESSE;
            NumeroCompte = NUMEROCOMPTE;
        
        
        }













    }
}
