using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAromaRazan.Modul
{
    public class DetailsFournisseurs
    {
     
        public string IdFournisseur { get; set; }
         public DateTime DateOperation { get; set; }
         public string  IdentifiantProudit { get; set; }
        public DetailsFournisseurs(){}

        public DetailsFournisseurs(string IDFOURNISSEUR ,   DateTime DATEOPERATION  , string IDENTIFIANTPRODUIT )
        {
            IdFournisseur = IDFOURNISSEUR;
             DateOperation = DATEOPERATION;
             IdentifiantProudit = IDENTIFIANTPRODUIT;
            
        }






    }
}
