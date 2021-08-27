using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Loc.Models
{
    public class Louer
    {
        public Location Location
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
