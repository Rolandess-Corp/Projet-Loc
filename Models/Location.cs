using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Loc.Models
{
    public class Location
    {
        public int IdLoc
        {
            get; set;
        }
        public DateTime DateLoc
        {
            get; set;
        }
        public Client Client

        {
            get; set;
        }
        public DateTime duree
        {
            get; set;
        }
        public string retourner
        {
            get; set;
        }
        public int IdUtulisation
        {
            get; set;
        }

    }
}
