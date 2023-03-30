using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAromaRazan.Modul
{
   public class Commande
    {
        public int IdCommande { get; set; }
        public string IdentifinatProduit { get; set; }
        public string CNIE_Client { get; set; }
        public int Qte { get; set; }
        public DateTime DateCommande { get; set; }
        public float Prix { get; set; }
        public float PrixTotal { get; set; }
        public Commande() { }

        public Commande(int IDCOMMANDE, string IDENTIFIANTPRODUIT, string CNIE_CLIENT, int QTE, DateTime DATECOMMANDE, float PRIX ,float PRIXTOTAL) 
        { 
            IdCommande=IDCOMMANDE;
            IdentifinatProduit=IDENTIFIANTPRODUIT;
            CNIE_Client=CNIE_CLIENT;
            Qte=QTE;
            DateCommande=DATECOMMANDE;
            Prix = PRIX;
            PrixTotal = PRIXTOTAL;
          }  
        
        









    }
}
