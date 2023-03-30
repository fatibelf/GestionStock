using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAromaRazan.Modul
{
     public class Categories
    {
        public string  IdCategorie { get; set; }
        public string DescriptionCat { get; set; }

        public Categories() { }
        public Categories(string IDCATEGORIE , string DESCRIPTIONCAT) 
        {
            IdCategorie = IDCATEGORIE;
            DescriptionCat = DESCRIPTIONCAT;
        }



    }
}
