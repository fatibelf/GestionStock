using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionAromaRazan.Modul
{
    public class Add_Product
    {
        public string identifiant { get; set; }
        public string NomProduit { get; set; }
        public int QteStock { get; set; }
        public string Prix { get; set; }
        public DateTime Date { get; set; }
        public byte[] Image { get; set; }
        public string Categorie { get; set; }

        public Add_Product() { }
        public Add_Product(string IDENTIFIANT, string NOMPRODUIT, int QTEDTOCK, string PRIX, DateTime DATE, byte[] IMAGE, string CATEGORIE)
        {
            identifiant = IDENTIFIANT;
            NomProduit = NOMPRODUIT;
            QteStock = QTEDTOCK;
            Prix = PRIX;
            Date = DATE;
            Image = IMAGE;
            Categorie = CATEGORIE;

        }


    }


}
