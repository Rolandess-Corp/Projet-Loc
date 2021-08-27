using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Loc.Models
{
    public class Article
    {
        public int idArticle
        {
            get; set;
        }
        public string Libelle
         {
            get; set;
        }
    public Categorie Categorie
        {
            get; set;
        }
        public int Pu
        {
            get; set;
        }
        public int Qte
        {
            get; set;
        }

    }
}
