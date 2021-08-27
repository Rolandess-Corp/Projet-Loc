using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Loc.Models
{
    public class Reserver
    {
        public int IdRes
        {
            get; set;
        }
        public Article Article
        {
            get; set;
        }
        public int Nombre
        {
            get; set;
        }
    }
}
